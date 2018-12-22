module AdventOfCodeYear2018Day04Challenge01

open System.IO
open System
open System.Text.RegularExpressions

let timestampRegex = new Regex @"\d{4}-\d{2}-\d{2}\s\d{2}\S\d{2}"
let guardIdRegex = new Regex @"\d+"

type LogEntryType = 
  | WakeUp
  | FallAsleep
  | BeginsShift of int

type GuardLog = { timestamp:DateTime; logEntryType: LogEntryType }

type SleepyTime = { totalMinutesAsleep: int; minutesAsleep: int list }

let solution =

  let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day04/Input.txt"

  let (|BeginsShift|_|) (input: string) = 
    match input.Split [|'#'|] with
    | [|_|] -> None
    | t -> 
      let guardLogIdMatch = guardIdRegex.Match <| Array.last t

      match guardLogIdMatch.Success with
      | true -> 
        let guardId = guardLogIdMatch.Value |> int
        Some(BeginsShift guardId)
      | false -> failwith "Unable to parse entry to guard log id" 

  let mapLogEntryPartToTimestamp timestampPart = 
    match timestampRegex.Match timestampPart with
    | t when t.Success -> 
      DateTime.Parse t.Value
    | _ -> failwith "Unable to parse entry to timestamp"

  let mapLogEntryPartToLogType logTypePart = 
    match logTypePart with
    | (p:string) when p.StartsWith("wakes") -> WakeUp
    | (p:string) when p.StartsWith("falls") -> FallAsleep
    | BeginsShift x -> BeginsShift x
    | _ -> failwith "Unable to parse all log entries" 

  let mapToGuardLog (logEntry: string) = 
    //First split the log entry into the timestamp and description parts.
    let firstPart, lastPart = 
      logEntry.Split [|']'|] 
      |> Array.map(fun x -> x.Trim())
      |> (fun x -> (Array.head x, Array.last x))

    //Map the first part to a timestamp
    let timestamp = mapLogEntryPartToTimestamp firstPart

    //Map the second part to the entry type.
    let logType = mapLogEntryPartToLogType lastPart

    { timestamp = timestamp; logEntryType = logType } 

  File.ReadAllLines filePath
  |> Seq.map mapToGuardLog
  |> Seq.sortBy(fun x -> x.timestamp)
  |> Seq.fold(fun (guardId, guardMap:Map<int, SleepyTime>, lastestFallAsleepTimestamp) guardLog -> 
    match guardLog.logEntryType with
    | FallAsleep -> (guardId, guardMap, guardLog.timestamp)
    | LogEntryType.BeginsShift nextGuardId -> (nextGuardId, guardMap, lastestFallAsleepTimestamp)
    | WakeUp -> 
      let guardEntries = guardMap.TryFind guardId

      let sleptFor = (guardLog.timestamp - lastestFallAsleepTimestamp).Minutes
      let minutesSleptFor = [lastestFallAsleepTimestamp.Minute..guardLog.timestamp.Minute]

      match guardEntries with
      | Some s -> 
        let sleepyTime = { 
          totalMinutesAsleep = s.totalMinutesAsleep + sleptFor; 
          minutesAsleep = List.append s.minutesAsleep minutesSleptFor 
        }

        (guardId, guardMap.Add(guardId, sleepyTime), lastestFallAsleepTimestamp)
      | None -> 
        let sleepyTime = { totalMinutesAsleep = sleptFor; minutesAsleep = minutesSleptFor }
        (guardId, guardMap.Add(guardId, sleepyTime), lastestFallAsleepTimestamp)

  ) (0, Map.empty<int, SleepyTime>, DateTime.MinValue) //GuardId, Map of guards
  |> (fun x -> 
    let _, guardMap, _ = x
    guardMap
  )
  |> (fun x -> 
    x
    |> Map.toList
    |> List.sortByDescending(fun s -> s |> snd |> (fun q -> q.totalMinutesAsleep))
    |> List.head
    |> (fun (i, v) ->
       let mostMinuteAsleep =
         v
         |> (fun x -> x.minutesAsleep)
         |> List.countBy id
         |> List.sortByDescending snd
         |> List.head
         |> fst
       (i, mostMinuteAsleep)
    )
  )
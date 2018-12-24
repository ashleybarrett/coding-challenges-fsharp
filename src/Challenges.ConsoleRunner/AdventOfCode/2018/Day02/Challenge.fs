module AdventOfCodeYear2018Day02Challenge

open System.IO
open Types

let solution =

  let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day02/Input.txt"

  let fileLinesMapped = 
    File.ReadAllLines(filePath)
    |> Seq.map(fun x ->
        x.ToCharArray()
        |> Seq.countBy(id)
        |> Seq.map snd
    )

  let partOneSolved = 
    let countsByRepeat input repeat = 
      input
      |> Seq.sumBy(fun x ->
        x
        |> Seq.exists(fun e -> e = repeat) 
        |> (fun m -> if m then 1 else 0)
      )

    countsByRepeat fileLinesMapped 2 * countsByRepeat fileLinesMapped 3

  let partTwoSolved = 
    let boxIds = File.ReadAllLines(filePath)
    let boxIdsHalfLength = (boxIds |> Seq.length) / 2
    let boxIdLength = boxIds |> Seq.head |> String.length
   
    let mapToStringArray (a:string) = a.ToCharArray() |> Array.map string

    seq {
        for outer in boxIds |> Seq.take boxIdsHalfLength do
        for inner in boxIds do
          match outer <> inner with
          | true -> yield (mapToStringArray outer, mapToStringArray inner)
          | _ -> ()
    }
    |> Seq.map(fun (o, i) ->
      o
      |> Array.zip i
      |> Array.filter(fun (l, r) -> l = r)
      |> Array.map fst
    )
    |> Seq.filter(fun x -> boxIdLength - (Array.length x) = 1)
    |> Seq.head
    |> Seq.reduce (+)

  { partOne = partOneSolved; partTwo = partTwoSolved }

    
    
open System

[<EntryPoint>]
let main argv =

    let isValid s = 
        match s with
        | " " | ""  | null -> false
        | _ -> true

    let read _ = Console.ReadLine()

    let inputList = 
        Seq.initInfinite read 
        |> Seq.takeWhile isValid
        |> Seq.map(fun x -> System.Int32.Parse x) 
        |> Seq.toList

    //https://www.hackerrank.com/challenges/fp-list-replication

    let printNTimes head n = 
        [0..(head-1)] |> List.iter(fun x -> printfn "%d" n)

    let head = inputList.[0]

    inputList.[1..]
    |> List.iter(fun x -> (printNTimes head x))

    0
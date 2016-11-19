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

    //https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list

    let printIfOdd i v = 
        match i with
        | x when i % 2 = 1 -> printfn "%d" v
        | _ -> ()

    inputList |> List.iteri (fun i v -> (printIfOdd i v))

    0
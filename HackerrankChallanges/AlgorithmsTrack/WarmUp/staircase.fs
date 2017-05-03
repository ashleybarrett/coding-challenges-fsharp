open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/staircase

    let size = Console.ReadLine() |> int

    [1..size]
    |> List.map(fun n -> 
        String.replicate (size - n) " " + String.replicate n "#")
    |> List.iter(fun n -> printfn "%s" n)

    0
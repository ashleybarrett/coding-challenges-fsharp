open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/time-conversion

    let input = 
        Console.ReadLine() 
        |> string 
        |> DateTime.Parse

    printfn "%A" input.TimeOfDay

    0
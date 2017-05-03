open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/solve-me-first

    let firstNumber = Console.ReadLine() |> int
    let secondNumber = Console.ReadLine() |> int

    printfn "%i" <| firstNumber + secondNumber

    0
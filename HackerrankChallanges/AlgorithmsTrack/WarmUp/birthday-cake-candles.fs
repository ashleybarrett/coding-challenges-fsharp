open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/birthday-cake-candles

    let size = Console.ReadLine() |> int
    let input = 
        let read = Console.ReadLine() |> string
        read.Split [| ' ' |]
        |> Array.map(int64)

    let max = input |> Array.max

    input
    |> Array.filter(fun n -> n = max)
    |> Array.length
    |> printfn "%i"

    0
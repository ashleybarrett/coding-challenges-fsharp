open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/staircase

    let input = 
        let read = Console.ReadLine() |> string

        read.Split [| ' ' |]
        |> Array.map(int64)

    let size = input.Length - 1

    let minMax = 
        [|0..size|]
        |> Array.map(fun n -> 
            input
            |> Array.mapi(fun i v ->
                match i with
                | _ when i <> n -> v
                | _ -> 0L
            )
            |> Array.sum
        )

    let min = minMax |> Array.min
    let max = minMax |> Array.max

    printfn "%i %i" min max

    0
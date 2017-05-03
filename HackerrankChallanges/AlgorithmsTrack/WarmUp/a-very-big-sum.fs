open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/a-very-big-sum

    let size = Console.ReadLine() |> int
    let input = Console.ReadLine() |>  string

    input.Split [|' '|]
    |> Array.map(int64)
    |> Array.sum
    |> printfn "%i"

    0
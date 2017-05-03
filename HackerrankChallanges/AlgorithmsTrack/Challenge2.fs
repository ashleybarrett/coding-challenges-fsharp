open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/simple-array-sum

    let size = Console.ReadLine() |> int
    let input = Console.ReadLine() |>  string

    input.Split [|' '|]
    |> Array.map(int)
    |> Array.sum
    |> printfn "%i"

    0
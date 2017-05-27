open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=16

    2I ** 1000
    |> string
    |> Seq.map(fun x -> x |> string |> int)
    |> Seq.sum
    |> printfn "%i"

    0
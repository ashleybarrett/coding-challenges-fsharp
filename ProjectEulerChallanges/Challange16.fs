open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=16
    let num = 2I
    let power = 1000

    num ** power
    |> string
    |> Seq.map(fun n -> int(n.ToString()))
    |> Seq.sum
    |> printfn "%d"

    0  
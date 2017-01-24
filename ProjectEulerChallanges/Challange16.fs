open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=15
    let num = float 2
    let power = 1000

    pown num power
    |> string
    //|> Seq.map(fun n -> int64(n.ToString()))
    //|> Seq.sum
    |> printfn "%s"

    0  
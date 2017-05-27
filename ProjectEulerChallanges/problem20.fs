open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=20

    seq [1I..100I]
    |> Seq.rev
    |> Seq.reduce(*)
    |> string
    |> Seq.map(string >> int)
    |> Seq.reduce(+)
    |> printfn "%i"

    0
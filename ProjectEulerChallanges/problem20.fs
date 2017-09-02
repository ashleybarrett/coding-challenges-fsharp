module Problem20

let solution =

    //https://projecteuler.net/problem=20

    seq [1I..100I]
    |> Seq.rev
    |> Seq.reduce(*)
    |> string
    |> Seq.map(string >> int)
    |> Seq.reduce(+)
    |> printfn "%i"
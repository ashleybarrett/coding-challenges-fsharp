module Problem16

let solution =

    //https://projecteuler.net/problem=16

    2I ** 1000
    |> string
    |> Seq.map(fun x -> x |> string |> int)
    |> Seq.sum
    |> printfn "%i"
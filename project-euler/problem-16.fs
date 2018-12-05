module Problem16
let solution =
    //https://projecteuler.net/problem=16

    let limit = 1000

    2I ** limit
    |> string
    |> Seq.sumBy(string >> int)
    |> ignore

    0
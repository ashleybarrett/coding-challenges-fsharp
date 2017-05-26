open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=9

    let number = 1000

    let sqr n = n * n 

    seq {
        for a in 1..number do
            for b in a..number do
                for c in a..number do
                    let aSqr, bSqr, cSqr = sqr a, sqr b, sqr c
                    match aSqr + bSqr = cSqr with
                    | true -> yield seq [ a; b; c ]
                    | false -> ()
    }
    |> Seq.find(fun x -> x |> Seq.sum = number)
    |> Seq.fold(*) 1
    |> printfn "%i"

    0
module Problem05

let solution =

    //https://projecteuler.net/problem=5

    let number = 20

    Seq.initInfinite(fun x -> x + 1)
    |> Seq.takeWhile(fun x -> 
        seq { 1..number } |> Seq.exists(fun n -> x % n <> 0 )
    )
    |> Seq.max
    |> (fun x -> x + 1 |> printfn "%i")
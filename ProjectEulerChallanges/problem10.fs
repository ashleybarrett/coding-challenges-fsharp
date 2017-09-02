module Problem10

let solution =

    //https://projecteuler.net/problem=10

    let getSqrt n = n |> float |> sqrt |> int64

    let isPrime n =
        seq {
            let sqrt = n |> float |> sqrt |> int64
            for i in 2L .. sqrt do yield i
        }
        |> Seq.forall(fun x -> n % x <> 0L)

    let upperValue = 2000000L

    seq {
        yield 2L
        for i in 3L..2L..upperValue do
            match isPrime i with
            | true -> yield i
            | false -> yield 0L
    }
    |> Seq.sum
    |> printfn "%i" 
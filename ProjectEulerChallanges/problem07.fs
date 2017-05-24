open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=7

    let number = 10000

    let isPrime n =
        seq {
            let sqrt = n |> float |> sqrt |> int
            for i in 2 .. sqrt do yield i
        }
        |> Seq.forall(fun x -> n % x <> 0)

    seq {
        yield 2
        for i in 3..2..200000 do 
            match isPrime i with
            | true -> yield i
            | false -> ()
    }
    |> Seq.item number
    |> printfn "%i"

    0
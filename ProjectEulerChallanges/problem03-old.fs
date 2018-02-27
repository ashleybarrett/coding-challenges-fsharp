module Problem03

let solution =

    //https://projecteuler.net/problem=3

    //let number = 13195L
    let number = 600851475143L

    let getSqrt n = n |> float |> sqrt |> int64

    let isPrime n =
        seq {
            let sqrt = n - 1L |> getSqrt
            for i in 2L .. sqrt do yield i
        }
        |> Seq.forall(fun x -> n % x <> 0L)

    seq {
        let sqrt = getSqrt number
        for i in 3L .. 2L .. sqrt do 
            match number % i = 0L with
            | true -> 
                match isPrime i with
                | true -> yield i
                | false -> ()
            | false -> ()
    }
    |> Seq.rev
    |> Seq.head
    |> printfn "%i"
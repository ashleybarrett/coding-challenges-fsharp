module Problem12

let solution =

    //https://projecteuler.net/problem=12

    let numberOfDivisors = 501L

    let getNumberOfDivisors n =
        seq {
            let sqrt = n |> float |> sqrt |> int64
            for i in 1L..sqrt do yield i
        }
        |> Seq.filter(fun x -> n % x = 0L)
        |> Seq.length
        |> int64
        |> (*) 2L

    1L
    |> Seq.unfold(fun x -> Some(x, x + 1L))
    |> Seq.map(fun x -> [1L..x] |> Seq.sum)
    |> Seq.find(fun x -> getNumberOfDivisors x >= numberOfDivisors)
    |> printfn "%i"
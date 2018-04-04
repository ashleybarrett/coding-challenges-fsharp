module Problem11
open System.Xml.XPath

let solution =
    //https://projecteuler.net/problem=12

    let numberOfDivisors = 500L

    let getNumberOfDivisors number =
        let sqrt = number |> float |> sqrt |> int64

        { 1L .. sqrt }
        |> Seq.filter(fun x -> number % x = 0L)
        |> Seq.length
        |> int64
        |> (*) 2L

    1L
    |> Seq.unfold(fun x -> Some(x, x + 1L))
    |> Seq.map(fun x -> [1L..x] |> Seq.sum)
    |> Seq.find(fun x -> getNumberOfDivisors x >= numberOfDivisors)
    |> ignore

    0
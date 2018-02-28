module Problem03
open System.Web.Security.AntiXss

let solution =
    //https://projecteuler.net/problem=3

    //let testNumber = 13195L
    let testNumber = 600851475143L

    let isFactor number candiate = number % candiate = 0L

    let isPrime number = 
        let oneLess = number - 1L
        seq { 2L .. oneLess }
        |> Seq.forall(fun x -> number % x <> 0L)

    seq { 3L .. 2L .. testNumber }
    |> Seq.filter(fun x -> isFactor testNumber x)
    |> Seq.filter(isPrime)
    |> Seq.max



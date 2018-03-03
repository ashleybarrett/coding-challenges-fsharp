module Problem10

let solution =
    //https://projecteuler.net/problem=10

    let testNumber = 1999999L

    let isPrime (number:int64) = 
        let sqrtOfNumber = number |> double |> sqrt |> int64
        { 2L .. sqrtOfNumber }
        |> Seq.forall(fun x -> number % x <> 0L)

    { 2L .. testNumber }
    |> Seq.filter(isPrime)
    |> Seq.sum
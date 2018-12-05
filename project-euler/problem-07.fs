module Problem07

let solution =
    //https://projecteuler.net/problem=7

    let nthPrimeIndex = 10000

    let isPrime number = 
        let oneLess = number - 1
        { 2 .. oneLess }
        |> Seq.forall(fun x -> number % x <> 0)
    
    Seq.unfold(fun x -> Some(x, x + 1)) 2
    |> Seq.filter(isPrime)
    |> Seq.item(nthPrimeIndex)



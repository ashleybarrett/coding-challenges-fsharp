module ProjectEulerChallenge21

let solution =
    //https://projecteuler.net/problem=21

    let maxNumber = 10000L

    let getSumOfDivisors number = 
        let half = number / 2L
        
        { 1L .. half }
        |> Seq.filter(fun x -> number % x = 0L)
        |> Seq.sum

    {1L .. maxNumber}
    |> Seq.sumBy (fun x ->
        let sumOfDivisorsLeft = getSumOfDivisors x
        let sumOfDivisorsRight = getSumOfDivisors sumOfDivisorsLeft
        
        let isAmicablePair = x = sumOfDivisorsRight && x <> sumOfDivisorsLeft

        match isAmicablePair with
        | true -> x
        | _ -> 0L
    )
    |> ignore

    0
module Problem21

let solution =

    //https://projecteuler.net/problem=21

    let upperNumber = 9999

    let getDivisors number = 
        seq {
            let half = number / 2
            for i in 1 .. half do 
                if number % i = 0 then yield i
        }

    let getDivisorsSum number = number |> getDivisors |> Seq.sum

    [1 .. upperNumber]
    |> Seq.filter(fun x -> 
        let divisorsSum = getDivisorsSum x
        let sumDivisorsSum = getDivisorsSum divisorsSum
        x = sumDivisorsSum && divisorsSum <> sumDivisorsSum
    )
    |> Seq.sum
    |> printfn "%i"
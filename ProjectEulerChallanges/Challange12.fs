open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=12

    let numberOfFactorsToDiscover = 500

    let numberOfFactors number = 
        let sqrtOfN = (float >> sqrt >> int) number

        {1..sqrtOfN}
        |> Seq.filter(fun n -> number % n = 0)
        |> Seq.length
        |> (*) 2

    Seq.initInfinite ((+) 2)
    |> Seq.scan (+) 1
    |> Seq.find(fun n -> 
        let factors = numberOfFactors n
        factors = numberOfFactorsToDiscover
    )
    |> printfn "%i"

    0 
open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=7
    let hasFactors n = 
        let upperBound = int32(Math.Sqrt(double(n)))
        let factors =
            [3..2..upperBound]
            |> List.filter(fun i -> n % i = 0)
        factors.Length = 0

    let isPrime n = 
        match n with
        | 1 -> false
        | 2 -> true
        | _ -> hasFactors n

    [3..2..1000000]
    |> List.filter(fun n -> isPrime n)
    |> List.item 9999
    |> printfn "%i"        

    0 
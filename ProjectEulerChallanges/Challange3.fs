open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    let num: int64 = 600851475143L
    //let num = 13195L

    let hasFactors n = 
        let upperBound = int64(Math.Sqrt(double(n)))
        let factors =
            [3L..2L..upperBound]
            |> List.filter(fun i -> n % i = 0L)
        factors.Length = 0

    let isPrime n = 
        match n with
        | 1L -> false
        | 2L -> true
        | _ -> hasFactors n

    let factors = 
        [3L..2L..num]
        |> List.filter(fun n -> isPrime n)
        |> List.filter(fun n -> num % n = 0L)
        |> List.rev

    printfn "%i" factors.[0]

    0 
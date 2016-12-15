open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=10

    let number = 10L

    let isPrime n = 
        let upperBound = int64(Math.Sqrt(double(n)))
        let factors =
            [3L..2L..upperBound]
            |> List.filter(fun i -> n % i = 0L)
        int64(factors.Length) = 0L
        
    let primesSum = 
        [3L..2L..2000000L]
        |> List.filter(fun n -> isPrime n)
        |> List.sum

    printfn "%i" <| primesSum + 2L

    0 
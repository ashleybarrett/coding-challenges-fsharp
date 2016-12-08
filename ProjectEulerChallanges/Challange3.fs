open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    let num: int64 = 600851475143L

    let rec isPrime n list = 
        match list with
        | _ when n = 1L -> false
        | _ when n = 2L -> true
        | _ when n % 2L = 0L -> false
        | head::_ when n % head = 0L -> false
        | head::tail -> isPrime n tail
        | [] -> true
        | _ -> false

    let factors = 
        [1L..num]
        |> List.filter(fun n -> (isPrime n [2L..(n-1L)]))
        |> List.filter(fun n -> num % n = 0L)
        |> List.rev

    printfn "%i" factors.[0]

    0 
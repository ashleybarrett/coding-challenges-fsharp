open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    let num = 600851475143I

    let rec isPrime n list = 
        match list with
        | _ when n = 1 -> false
        | _ when n = 2 -> true
        | _ when n % 2 = 0 -> false
        | head::_ when n % head = 0 -> false
        | head::tail -> isPrime n tail
        | [] -> true
        | _ -> false

    let factors = 
        [1..num]
        |> List.filter(fun n -> (isPrime n [2..(n-1)]))
        |> List.filter(fun n -> num % n = 0)
        |> List.rev

    printfn "%i" factors.[0]

    0 
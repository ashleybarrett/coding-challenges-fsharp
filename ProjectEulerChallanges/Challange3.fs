open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    let limit = 100

    let rec isPrime n list = 
        match list with
        | _ when n = 1 -> false
        | head::_ when n % 2 = 0 -> false
        | head::_ when n % head = 0 -> false
        | head::tail -> isPrime n tail
        | [] -> true
        | _ -> false

    [1..limit]
    |> List.filter(fun n -> (isPrime n [3..(n-1)]))
    |> List.iter(fun n -> printfn "%i" n)
    0 
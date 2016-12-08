open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    //let num: int64 = 600851475143L
    let num = 13195


    (*
    let rec largestPrimeFactor numbers = 
        match numbers with
        | head::tail when isPrime head tail && num % head = 0L -> true
        | _::tail -> largestPrimeFactor tail
        | [] -> false
        | _ -> false *)

    let rec isPrime n list = 
        match list with
        | head::_ when n % head = 0 -> false
        | head::tail -> isPrime n tail
        | [] -> true
        | _ -> false

    let factors = 
        [3..2..num]
        |> List.filter(fun n -> isPrime n [2..(n-1)])
        |> List.filter(fun n -> num % n = 0)
        |> List.rev

    printfn "%i" factors.[0]

    0 
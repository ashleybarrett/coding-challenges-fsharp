open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    //let num: int64 = 600851475143L
    let num = 13195L

    let rec isPrime n list = 
        match list with
        | head::_ when n % head = 0L -> false
        | head::tail -> isPrime n tail
        | [] -> true
        | _ -> false

    let factors = 
        [3L..2L..num]
        |> List.filter(fun n -> isPrime n [2L..(n-1L)])
        |> List.filter(fun n -> num % n = 0L)
        |> List.rev

    printfn "%i" factors.[0]

    0 
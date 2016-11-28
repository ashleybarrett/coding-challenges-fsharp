open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    
    let isPrime n =
        match n with
        | _ when n >= 3 -> true
        | _ -> false

    [1..10]
    |> List.filter(fun n -> isPrime n)
    |> List.iter(fun n -> printfn "%i" n)
    0 
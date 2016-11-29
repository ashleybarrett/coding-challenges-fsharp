open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=3
    let limit = 10

    let isPrime n =
        match n with
        | _ when n = 1 -> false
        | _ when n = 2 -> true
        | _ when n % 2 = 0 -> false
        | _ -> true  

    [1..limit]
    |> List.iter(fun n -> printfn "%i %b" n (isPrime n))
    //|> List.filter(fun n -> isPrime n)
    //|> List.iter(fun n -> printfn "%i" n)
    
    (*
    let rec doPrint list =
        match list with
        | [] -> ()
        | head::tail -> 
            printfn "%i" head 
            doPrint tail

    doPrint [1..100]
    *)
    0 
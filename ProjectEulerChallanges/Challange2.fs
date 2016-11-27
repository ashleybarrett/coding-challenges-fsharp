open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=2
    
    [1..10]
    |> List.fold (fun x y -> x + y) 0
    |> printfn "%i"

    0 
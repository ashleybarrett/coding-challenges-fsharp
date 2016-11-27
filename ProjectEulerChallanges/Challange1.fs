open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=1
    [1..999] 
    |> List.filter(fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum
    |> printfn "%i"

    0 
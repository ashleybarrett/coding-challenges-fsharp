open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=1

    [1..999]
    |> List.filter(fun n -> n % 3 = 0 || n % 5 = 0)
    |> List.sum
    |> printf "%i"

    0
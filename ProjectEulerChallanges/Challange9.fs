open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=9

    let number = 25

    let squared n = n * n

    let squares = 
        [1..number]
        |> List.iter(fun n -> squared n) 

    

    0 
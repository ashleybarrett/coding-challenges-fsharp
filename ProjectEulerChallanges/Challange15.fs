open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=15
    let size = 3

    [1..size]
    |> List.rev
    |> List.map(fun n -> 
        let remainingRows = n - 1
        size + ((size * remainingRows) - remainingRows)
    )
    |> List.sum
    |> (+)1
    |> printfn "%i"   

    0  
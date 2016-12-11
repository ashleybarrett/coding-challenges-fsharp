open System

[<EntryPoint>]
let main argv = 
    
    let square n = n * n

    let numbers = {1..100}

    //https://projecteuler.net/problem=6
    let sumOfSquares = 
        numbers
        |> Seq.map(fun n -> square n)
        |> Seq.sum

    let squareOfSums =
        numbers
        |> Seq.sum
        |> square
        
    printfn "%i" <| squareOfSums - sumOfSquares

    0 
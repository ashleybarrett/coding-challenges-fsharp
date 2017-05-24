open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=6

    let maxNumber = 100

    let sumOfSqrs = 
        seq { for i in 1..maxNumber do yield i * i }
        |> Seq.sum

    let sqrOfSum = 
        seq { for i in 1..maxNumber do yield i }
        |> Seq.sum
        |> (fun x -> x * x)

    sqrOfSum - sumOfSqrs |> printfn "%i"

    0
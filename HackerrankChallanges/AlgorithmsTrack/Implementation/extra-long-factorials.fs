open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/extra-long-factorials

    let size = Console.ReadLine() |> int
    let bigSize = bigint(size)
    let sizeMinusOne = bigSize - 1I

    [1I..sizeMinusOne]
    |> List.rev
    |> List.fold(*) bigSize
    |> printfn "%A"

    0
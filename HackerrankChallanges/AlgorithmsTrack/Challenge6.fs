open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/plus-minus 
        
    let size = Console.ReadLine() |> int
    let input = 
        let read = Console.ReadLine() |> string
        read.Split [|' '|]
        |> Array.map(int)

    let findFractionalAndPrint inputLength num = 
        (float)num / (float)inputLength |> printfn "%f"

    let numberOfPositive = input |> Array.filter(fun n -> n > 0) |> Array.length
    let numberOfZeros = input |> Array.filter(fun n -> n = 0) |> Array.length
    let numberOfNegitive = input |> Array.filter(fun n -> n < 0) |> Array.length

    findFractionalAndPrint size numberOfPositive
    findFractionalAndPrint size numberOfNegitive
    findFractionalAndPrint size numberOfZeros

    0
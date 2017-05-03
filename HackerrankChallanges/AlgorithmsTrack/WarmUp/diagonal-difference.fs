open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/diagonal-difference 
        
    let size = Console.ReadLine() |> int
    let input = 
        Seq.initInfinite (fun _ -> Console.ReadLine() |> string)
        |> Seq.takeWhile(fun n ->
            match n with
            | " " | ""  | null -> false
            | _ -> true
        )
        |> Seq.map(fun n -> 
            n.Split [|' '|]
            |> Array.map(int)
        ) 
        |> Seq.toArray

    let totalForDiagonal (input:int[][]) =
        let count = 0
        let inputSize = input.Length - 1

        [0..inputSize]
        |> List.map(fun n -> input.[n].[n])
        |> List.sum

    let leftToRight = totalForDiagonal input
    let rightToLeft = input |> Array.rev |> totalForDiagonal

    printfn "%i" (abs <| leftToRight - rightToLeft)

    0
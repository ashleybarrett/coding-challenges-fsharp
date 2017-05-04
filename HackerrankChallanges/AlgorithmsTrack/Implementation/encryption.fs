open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/encryption

    let input  = Console.ReadLine() |> string
    let numberOfColumns = 
        input.Length
        |> float 
        |> Math.Sqrt 
        |> Math.Ceiling
        |> int

    input.ToCharArray()
    |> Array.toSeq
    |> Seq.map(string)
    |> Seq.mapi (fun i v -> i % numberOfColumns, v)
    |> Seq.groupBy fst
    |> Seq.map(fun (i,v) -> 
        v 
        |> Seq.map(snd)
        |> Seq.reduce(+)
    )
    |> Seq.reduce(fun ac el -> ac + " " + el)
    |> printfn "%s"

    0
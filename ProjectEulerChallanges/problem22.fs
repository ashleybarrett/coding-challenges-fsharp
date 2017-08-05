open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=22

    let letters = [| 'A'..'Z' |]

    System.IO.File.ReadLines("ProjectEulerChallanges/problem22-names.txt")
    |> Seq.collect(fun n ->
        n.Split [|','|]
        |> Seq.map(fun s -> s.Replace('\"',' ').Trim())
    )
    |> Seq.sort
    |> Seq.mapi(fun i v -> 
        (Array.sumBy (fun c -> 
            letters 
            |> Array.findIndex ((fun e -> e = c)) 
            |> (fun x -> x + 1)) (v.ToCharArray()))
        |> (fun s -> (i + 1) * s)
    )
    |> Seq.sum
    |> ignore

    0
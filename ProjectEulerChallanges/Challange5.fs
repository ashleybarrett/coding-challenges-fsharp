open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=5

    let rec divisibleByAll candidate numbers =
        match numbers with
        | head::tail when candidate % head = 0 -> divisibleByAll candidate tail
        | head::tail when candidate % head <> 0 -> false
        | [] -> true

    {20..20..2000000000}
    |> Seq.find(fun n -> divisibleByAll n [1..20])
    |> printfn "%i"

    0 
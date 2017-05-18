module SherlockAndValidString

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/sherlock-and-valid-string

    (Console.ReadLine() |> string).ToCharArray()
    |> Array.countBy id
    |> Array.map snd
    |> Array.groupBy id
    |> (fun n ->
        match n.Length with 
        | 1 -> printfn "%s" "YES"
        | 2 -> 
            match n.[1] |> snd |> Array.length with
            | len when len > 1 -> printfn "%s" "NO"
            | _ -> printfn "%s" "YES"
        | _ -> printfn "%s" "NO"
    )

    0
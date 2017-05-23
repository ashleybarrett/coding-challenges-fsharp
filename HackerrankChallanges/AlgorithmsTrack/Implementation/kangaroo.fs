module Kangaroo

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/kangaroo

    let input = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.toList |> List.map int
    let k1, d1, k2, d2 = input.[0], input.[1], input.[2], input.[3]

    (1,(k1, k2))
    |> List.unfold(fun (i, v) ->
        let kn1, kn2 = fst v, snd v

        match i <= 10000 with
        | true -> Some((i,v),(i+1,(kn1+d1,kn2+d2)))
        | false -> None
    )
    |> List.map snd
    |> List.exists(fun (k1,k2) -> k1 = k2)
    |> (fun n -> 
        let s = if n then "YES" else "NO" 
        printfn "%s" s
    )

    0
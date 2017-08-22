open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=25

    let digitsToFind = 1000

    (1, (0I, 1I))
    |> Seq.unfold(fun (i, (n1, n2)) -> 
        Some(
            (i, (n1 , n2)), (i + 1, (n2, n1 + n2))
        )
    )
    |> Seq.skipWhile(fun (_, (_, n2)) -> 
        n2 
        |> string 
        |> String.length 
        |> (fun x -> x < digitsToFind)
    )
    |> Seq.head
    |> fst
    |> (fun x -> printfn "%i" x)
    |> ignore

    0
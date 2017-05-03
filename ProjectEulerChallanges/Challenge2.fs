open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=2

    Seq.unfold(fun (l, r) ->
        let next = l + r

        match next with
        | n when n <= 4000 -> Some(next, (r, next)) 
        | _ -> None

    ) (0,1)
    |> Seq.filter(fun n -> n % 2 = 0)
    |> Seq.sum
    |> printfn "%i"

    0 
open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=2

    Seq.unfold(fun (l, r) ->
        let next = l + r
        if next <= 4000000 
            then Some(next, (r, next)) 
        else None
    ) (0,1)
    |> Seq.filter(fun n -> n % 2 = 0)
    |> Seq.sum
    |> printfn "%i"

    0 
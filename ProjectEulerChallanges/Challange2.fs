open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=2

    let doesNotExceed = 4000000

    Seq.unfold(
            fun (a,b) -> 
                let next = a + b
                match next <= doesNotExceed with 
                | true -> Some(next, (b, next))
                | _ -> None
    ) (0,1)
    |> Seq.filter(fun x -> x % 2 = 0)
    |> Seq.sum
    |> printfn "%i"

    0 
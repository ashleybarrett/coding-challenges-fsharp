open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=2

    let upperValue = 4000000

    (0,1) 
    |> Seq.unfold(fun (v1,v2) -> Some((v1,v2), (v2, v1 + v2)))
    |> Seq.takeWhile(fun x -> snd x <= upperValue)
    |> Seq.sumBy(fun x ->
        let v = snd x
        match v % 2 = 0 with
        | true -> v
        | false -> 0
    )
    |> printfn "%A"

    0
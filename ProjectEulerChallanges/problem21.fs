open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=21

    //Unfinished

    let allPairs = 
        seq[1..300]
        |> Seq.map(fun n -> 
            let sqrt = n |> float |> sqrt |> int
            [1..sqrt]
            |> Seq.filter (fun x -> n % x = 0)
            //|> Seq.collect (fun x -> [x; n/x])
            //|> Seq.filter (fun x -> x <> n)
            //|> Seq.filter(fun n -> x % n = 0)
            //|> Seq.sum
            //|> (fun x -> (n,x))
        )
        |> Seq.iter(fun x -> printfn "%A" x)
    
    allPairs
    |> Seq.filter(fun x ->
        allPairs |> Seq.exists(fun n -> fst x = snd n && snd x <> fst n)
    )
    //|> Seq.sumBy snd
    |> (fun x -> x |> Seq.length |> printfn "%i")
    //|> printfn "%A"

    0
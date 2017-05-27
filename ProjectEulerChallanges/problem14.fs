open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=14

    let upperBound = 999999L

    seq [1L..upperBound]
    |> Seq.map(fun x ->
        x |>
        Seq.unfold(fun n -> 
            match n with
            | 1L -> None
            | n when n % 2L = 0L -> Some(n, n / 2L)
            | _ -> Some(n, (n * 3L) + 1L)
        )
        |> Seq.length
        |> (fun n -> (x,n))
    )
    |> Seq.maxBy snd
    |> fst
    |> printfn "%i"

    0
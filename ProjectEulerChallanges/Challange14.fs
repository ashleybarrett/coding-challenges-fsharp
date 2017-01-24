open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=14

    let isEven n = n % 2L = 0L

    let half n = n / 2L

    let timesThreePlusOne n = n |> (*)3L |> (+)1L

    let number, lengthOfSeq = 
        [1L..999999L]
        |> List.map(fun n -> 
            List.unfold(fun n -> 
                match n with
                | 1L -> None
                | n when isEven n -> Some(n, half n)
                | _ -> Some(n, timesThreePlusOne n)
            ) n
            |> List.length
            |> (+)1
            |> (fun x -> (n, x))
        )
        |> List.maxBy(fun (_,n) -> +n)

    printfn "%d %d" number lengthOfSeq

    0 
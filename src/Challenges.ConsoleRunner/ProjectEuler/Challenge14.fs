module ProjectEulerChallenge14

let solution =
    //https://projecteuler.net/problem=14

    let upperNumber = 999999L

    let isEven number = number % 2L = 0L

    let getCollatzChainLength number =
        Seq.unfold(fun x ->
            let isNumberEven = isEven x

            match x, isNumberEven with
            | 1L, _ -> None
            | _, true -> Some(x, x / 2L)
            | _, false -> Some(x, x * 3L |> (+)1L)
        ) number
        |> Seq.length

    {1L..upperNumber}
    |> Seq.map(fun x -> (x, getCollatzChainLength x))
    |> Seq.maxBy snd
    |> fst
    |> ignore

    0
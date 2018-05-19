module Problem20

let solution =
    //https://projecteuler.net/problem=20

    let max = 100I

    (max, max)
    |> Seq.unfold(fun (number, acc) ->
        let nextNumber = number - 1I
        let nextAcc = nextNumber * acc
        Some((number, acc), (nextNumber, nextAcc))
    )
    |> Seq.takeWhile(fun (number, _) -> number > 0I)
    |> Seq.last
    |> snd
    |> string
    |> Seq.sumBy(fun x -> x |> string |> int)
    |> ignore

    0
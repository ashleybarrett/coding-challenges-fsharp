module Problem02

let solution =
    //https://projecteuler.net/problem=2

    (1, 1)
    |> Seq.unfold(fun (num, acc) -> Some((num,acc),(acc, num + acc)))
    |> Seq.takeWhile(fun (_, acc) -> acc < 4000000)
    |> Seq.map(fun (_, acc) -> acc)
    |> Seq.filter(fun x -> x % 2 = 0)
    |> Seq.sum


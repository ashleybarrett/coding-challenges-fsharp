module Problem02

let solution =
    //https://projecteuler.net/problem=2

    let maxNumber = 4000000

    (1, 1)
    |> Seq.unfold(fun (num, acc) -> Some((num,acc),(acc, num + acc)))
    |> Seq.takeWhile(fun (_, acc) -> acc < maxNumber)
    |> Seq.map(fun (_, acc) -> acc)
    |> Seq.filter(fun x -> x % 2 = 0)
    |> Seq.sum


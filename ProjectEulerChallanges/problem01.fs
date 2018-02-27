module Problem01

let solution =

    //https://projecteuler.net/problem=1

    let isMultipleOf number mltipleNumber = number % mltipleNumber = 0

    seq { 1 .. 999 }
    |> Seq.filter(fun x -> isMultipleOf x 3 || isMultipleOf x 5)
    |> Seq.sum
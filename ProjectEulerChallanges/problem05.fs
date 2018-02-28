module Problem05

let solution =
    //https://projecteuler.net/problem=5

    let lowerNumber = 1
    let upperNumber = 20

    let dividesByAll candiate lowerNumber upperNumber =
        { lowerNumber .. upperNumber }
        |> Seq.forall(fun x -> candiate % x = 0)
        
    Seq.unfold(fun x -> Some(x, x + 1)) upperNumber
    |> Seq.map(fun x -> x * upperNumber)
    |> Seq.filter(fun x -> dividesByAll x lowerNumber upperNumber)
    |> Seq.head




module Problem05

let solution =
    //https://projecteuler.net/problem=4

    let upperNumber = 20
    let lowerNumber = 1

    let dividesByAll candiate lowerNumber upperNumber =
        seq { lowerNumber .. upperNumber }
        |> Seq.forall(fun x -> candiate % x = 0)
        
    Seq.unfold(fun x -> Some(x, x + 1)) upperNumber
    |> Seq.map(fun x -> x * upperNumber)
    |> Seq.filter(fun x -> dividesByAll x lowerNumber upperNumber)
    |> Seq.head
    |> printfn "%A"




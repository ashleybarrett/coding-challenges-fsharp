module Problem01

let solution = 

    //https://projecteuler.net/problem=1

    seq { 
        for i in 1 .. 999 do 
            match i % 3 = 0 || i % 5 = 0 with
            | true -> yield i
            | false -> ()
    }
    |> Seq.sum
    |> printfn "%i"
open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=23

    let upperBound = 24

    let isAbundantNumber numberToTest =
        seq {
            let half = numberToTest / 2
            for i in 1 .. half do yield i 
        }
        |> Seq.filter(fun n -> numberToTest % n = 0)
        |> Seq.sum
        |> (fun n -> n > numberToTest)

    seq {
        for i in 1 .. upperBound do 
            if isAbundantNumber i then yield i
    }
    |> Seq.iter(fun n -> printfn "%i" n)
    |> ignore

    0
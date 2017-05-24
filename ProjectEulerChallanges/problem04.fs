open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=4

    let maxNumber = 999

    seq {
        for i in 10..maxNumber do
            yield! seq {
                for y in 10..maxNumber do 
                    let factor = i * y
                    let factorStr = factor |> string
                    let factorStrRev = 
                        factorStr.ToCharArray() 
                        |> Array.map string
                        |> Array.rev 
                        |> Array.reduce(+)

                    match factorStr.Equals(factorStrRev) with
                    | true -> yield factor
                    | false -> ()
            }
    }
    |> Seq.max
    |> printfn "%i"

    0
module Problem19
open System

let solution =
    //https://projecteuler.net/problem=19

    let firstYear = 1901
    let lastYear = 2000

    
    seq {
        for year in firstYear .. lastYear do
        for month in 1 .. 12 do
            let date = new DateTime(year, month, 1)

            match date.DayOfWeek = DayOfWeek.Sunday with
            | true -> yield 1
            | _ -> ()
    }
    |> Seq.sum
    |> ignore

    0
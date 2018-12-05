module Problem01
open System.IO

let solution =

    let filePath = "advent-of-code/2018/problem-01-frequencies.txt"

    File.ReadLines(filePath)
    |> Seq.map(fun x -> x |> int)
    |> Seq.sum
    |> ignore

    0
module AdventOfCodeYear2018Day01Challenge01

open System.IO

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day01/Input.txt"

    File.ReadLines(filePath)
    |> Seq.map(fun x -> x |> int)
    |> Seq.sum
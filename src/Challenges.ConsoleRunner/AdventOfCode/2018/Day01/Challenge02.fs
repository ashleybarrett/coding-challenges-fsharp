module AdventOfCodeYear2018Day01Challenge02

open System.IO

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day01/Input.txt"

    let getFileLines inputFilePath = 
        File.ReadAllLines(inputFilePath) 
        |> Seq.map(fun x -> x |> int)
        |> Seq.toList

    seq{
        while(true) do
            yield! getFileLines filePath
    }
    |> Seq.scan(fun (currentFreq, seenFreqs) lineItem ->
        let nextFreq = currentFreq + lineItem
        (nextFreq, seenFreqs |> Set.add currentFreq)
    ) (0, Set.empty)
    |> Seq.find(fun (currentFreq, seenFreqs) -> 
        seenFreqs |> Set.contains currentFreq
    )
    |> fst
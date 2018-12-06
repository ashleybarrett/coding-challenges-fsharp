module Problem02
open System.IO
let solution =

    let filePath = "advent-of-code/2018/problem-frequencies.txt"

    let getFileLines inputFilePath = 
        File.ReadLines(inputFilePath) 
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
    |> ignore



    0
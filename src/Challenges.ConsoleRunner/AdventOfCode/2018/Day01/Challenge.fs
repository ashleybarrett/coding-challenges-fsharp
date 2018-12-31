module AdventOfCodeYear2018Day01Challenge

open Types
open FileInputProvider

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day01/Input.txt"

    let input = readInputAndMapToInts filePath

    let partOneSolved = input |> Seq.sum
    
    let partTwoSolved = 
        seq{
            while(true) do
                yield! input
        }
        |> Seq.scan(fun (currentFreq, seenFreqs) lineItem ->
            let nextFreq = currentFreq + lineItem
            (nextFreq, seenFreqs |> Set.add currentFreq)
        ) (0, Set.empty)
        |> Seq.find(fun (currentFreq, seenFreqs) -> 
            seenFreqs |> Set.contains currentFreq
        )
        |> fst
    
    { 
        partOne = partOneSolved; 
        partTwo = partTwoSolved
    }
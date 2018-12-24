module AdventOfCodeYear2018Day01Challenge

open System.IO
open Types

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day01/Input.txt"

    let mapInputLines = File.ReadAllLines(filePath) |> Seq.map int

    let partOneSolved = mapInputLines |> Seq.sum
    
    let partTwoSolved = 
        seq{
            while(true) do
                yield! mapInputLines
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
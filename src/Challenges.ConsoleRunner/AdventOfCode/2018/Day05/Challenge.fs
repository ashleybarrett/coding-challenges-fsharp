module AdventOfCodeYear2018Day05Challenge

open System.IO
open Types

let solution = 

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day05/Input.txt"

    let getFileInput = File.ReadAllLines filePath

    let fileLineInput = 
        getFileInput 
        |> Array.map(fun x -> x.ToCharArray() |> Array.map int) 
        |> Array.head 

    let partOneSolved = 
        let appendToChars chars c = Array.append chars [|c|]

        fileLineInput
        |> Array.fold(fun chars currentChar -> 
            match chars with
            | [||] -> appendToChars chars currentChar
            | _ ->
                let lastChar = Array.last chars
                match abs(lastChar - currentChar) = 32 with
                | false -> appendToChars chars currentChar
                | _ -> if chars.Length > 1 then chars.[0..chars.Length - 2] else Array.empty
        ) [||]
        |> Array.length

    { partOne = partOneSolved; partTwo = 0 }
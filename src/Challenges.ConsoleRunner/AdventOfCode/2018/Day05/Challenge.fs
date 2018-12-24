module AdventOfCodeYear2018Day05Challenge

open System.IO
open System
open Types

let solution = 

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day05/Input.txt"

    let getFileInput = File.ReadAllLines filePath

    let fileLineInput = 
        getFileInput 
        |> Array.map(fun x -> x.ToCharArray() |> Array.map int) 
        |> Array.head 

    let partOneSolved = 
        let charsMatch (l:int) (r:int) = abs(l - r) = 32

        let appendToChars chars c = Array.append chars [|c|]

        fileLineInput
        |> Array.fold(fun chars currentChar -> 
            match chars with
            | [||] -> appendToChars chars currentChar
            | [|c|] -> 
                match charsMatch c currentChar with
                | false -> appendToChars chars currentChar
                | _ -> Array.empty    
            | _ -> 
                let lastChar = Array.last chars
                
                match charsMatch lastChar currentChar with
                | false -> appendToChars chars currentChar
                | _ ->                     
                    let len = chars.Length - 2
                    chars.[0..len]

        ) [||]
        |> Array.length

    { partOne = partOneSolved; partTwo = 0 }
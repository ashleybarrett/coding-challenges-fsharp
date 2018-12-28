module AdventOfCodeYear2018Day05Challenge

open System.IO
open Types
open System
open System.Text.RegularExpressions

let solution = 

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day05/Input.txt"

    let getFileInput = File.ReadAllLines filePath |> Array.head
    
    let mapInputNumericCharValue (input:string) = input.ToCharArray() |> Array.map int

    let createPolymer inputChars = 
        let appendToChars chars c = Array.append chars [|c|]

        inputChars
        |> Array.fold(fun chars currentChar -> 
            match chars with
            | [||] -> appendToChars chars currentChar
            | _ ->
                let lastChar = Array.last chars
                match abs(lastChar - currentChar) = 32 with
                | false -> appendToChars chars currentChar
                | _ -> if chars.Length > 1 then chars.[0..chars.Length - 2] else Array.empty
        ) [||]
        |> Array.map char

    let partOneSolved = 
        getFileInput 
        |> mapInputNumericCharValue 
        |> createPolymer
        |> Array.length
    
    let partTwoSolved = 
        let input = getFileInput

        [|'A'..'Z'|]
        |> Array.map(fun x ->
            Regex.Replace(input, x.ToString(), "", RegexOptions.IgnoreCase)
            |> mapInputNumericCharValue
            |> createPolymer
            |> Array.length
        )
        |> Array.sort
        |> Array.head

    { partOne = partOneSolved; partTwo = partTwoSolved }
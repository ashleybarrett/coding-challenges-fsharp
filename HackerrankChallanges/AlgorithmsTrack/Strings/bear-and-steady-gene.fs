module RichieRich

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/bear-and-steady-gene

    Console.ReadLine() |> int |> ignore
    let input = (Console.ReadLine() |> string).ToCharArray() |> Array.map string |> Array.toList
    
    let countOfEachChar = input.Length / 4
    let remainingCountForChar i l c = 
        i 
        |> List.filter(fun n -> n = c)
        |> List.length 
        |> (-)l 
        |> (fun n -> if n < 0 then 0 else n)

    let remainingChars = ["A";"C";"G";"T"] |> List.map(fun n -> (n, remainingCountForChar input countOfEachChar n))
    let remainingCharsSum = List.sumBy snd remainingChars
    //printfn "%A" remainingChars
    match remainingCharsSum with
    | 0 -> printfn "%i" 0
    | _ -> 
        let maxLength = input.Length - 1
        [remainingCharsSum..maxLength]
        |> List.map(fun n ->
                List.windowed n input
                |> printfn "%A"
            )
        |> ignore


    0
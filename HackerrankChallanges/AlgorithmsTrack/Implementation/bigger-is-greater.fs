open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/bigger-is-greater

    //Unfinished

    let reduceToWord charList = charList |> List.reduce(+)

    let rec wordPermutations charList originalWord =
        let wordFromChars = reduceToWord charList
        printfn "%s" wordFromChars

        let nextCharList = List.append charList.Tail [charList.Head]
        let nextWord = reduceToWord nextCharList

        match nextWord with
        | w when w <> originalWord -> wordPermutations nextCharList originalWord
        | _ -> ()

    
    let word = "post"

    let charsFromWord = 
        word.ToCharArray()
        |> Array.map(string)
        |> Array.toList

    wordPermutations charsFromWord word

    0
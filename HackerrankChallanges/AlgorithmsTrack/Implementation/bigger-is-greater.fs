module Biggerisgreater

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/bigger-is-greater

    //Unfinished

    let reduceToWord charList = charList |> List.reduce(+)

    let word = "post"

    let charsFromWord = 
        word.ToCharArray()
        |> Array.map(string)
        |> Array.toList

    

    (*List.unfold(fun ((charList: list<string>), orginalWord) -> 
        let nextCharList = List.append charList.Tail [charList.Head]
        let nextWord = reduceToWord nextCharList

        match nextWord with
        | w when w <> orginalWord -> Some(nextCharList, (nextCharList,  word))
        | _ -> None
    ) (charsFromWord, word)
    |> List.map(fun n -> List.reduce(+) n)
    |> List.append [word]
    |> List.iter(fun n -> printfn "%s" n)*)

    0
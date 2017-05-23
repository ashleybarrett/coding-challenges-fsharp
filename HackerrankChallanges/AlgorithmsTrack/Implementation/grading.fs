open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/grading

    let numberOFTestCases = Console.ReadLine() |> int
    let testCases = List.init numberOFTestCases (fun _ -> Console.ReadLine() |> int)

    testCases
    |> List.map(fun n -> 
        match n < 38 with
        | false ->
            let remainder = n % 5
            let scoreDiff = 5 - remainder

            match scoreDiff with
            | 1 | 2 -> n + scoreDiff
            | _ -> n
        | true -> n
    )
    |> List.iter(fun n -> printfn "%i" n)

    0
module CompareTheTriplets

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/compare-the-triplets

    let input = 
        Seq.init 2 (fun n ->
            (Console.ReadLine() |> string).Split[|' '|] 
            |> Array.map(int) 
        ) |> Seq.toArray

    let numberOfBetterScores (alice: array<int>) (bob: array<int>) =
        alice
        |> Array.mapi(fun i v -> 
            match v with
            | _ when v > bob.[i] -> "a"
            | _ when v < bob.[i] -> "b"
            | _ -> ""
        )

    let filteredScores = numberOfBetterScores input.[0] input.[1]
    let aliceScores = filteredScores |> Array.filter(fun n -> n = "a") |> Array.length
    let bobScores = filteredScores |> Array.filter(fun n -> n = "b") |> Array.length

    printf "%i %i" aliceScores bobScores

    0
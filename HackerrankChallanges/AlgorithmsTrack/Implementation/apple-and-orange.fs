module AppleAndOrange

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/apple-and-orange

    let fruitLandedOnHouse house tree fruit = 
        let position = tree + fruit
        
        match position <= snd house && position >= fst house with
        | true -> 1
        | false -> 0

    let house = 
        let readInput = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int
        (readInput.[0], readInput.[1])

    let trees =
        let readInput = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int
        (readInput.[0], readInput.[1])

    let appleAndOranges = 
        let readInput = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int
        (readInput.[0], readInput.[1])
    
    let apples = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int

    let oranges = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int

    Array.sumBy (fun n -> fruitLandedOnHouse house (fst trees) n) apples
    |> printfn "%i"

    Array.sumBy (fun n -> fruitLandedOnHouse house (snd trees) n) oranges
    |> printfn "%i"

    0
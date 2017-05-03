open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/compare-the-triplets

    let readForPerson = Console.ReadLine() |> string

    let split (input:string) = input.Split [|' '|] |> Array.map(int)

    let numberOfBetterScores personx persony =
        let numberOfBetterScores = 0
        
        personx
        |> Array.iteri(fun i v -> 
            (*match v with
            | _ when v > persony.[i] -> numberOfBetterScores++
            | _ -> ()*)
            printfn "%i %i" i v
        )

        numberOfBetterScores


    let alice = readForPerson
    printfn "%A" alice
    let bob = readForPerson
    printfn "%A lll" bob

    //let aliceScores = numberOfBetterScores alice bob
    //let bobScores = numberOfBetterScores bob alice

    //printf "%i %i" aliceScores bobScores

    0
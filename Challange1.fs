open System

[<EntryPoint>]
let main argv = 
    let PrintIfLess upperLimit number = 
        match number with
        | u when number < upperLimit -> printfn "%d" number
        | _  -> ()

    let Valid s = 
        match s with
        | " " | "" -> false
        | _ -> true

    let values = 
        Seq.initInfinite(fun x -> Console.ReadLine())
        |> Seq.takeWhile (fun x -> Valid x) 
        |> Seq.map(fun x -> System.Int32.Parse x)

    let upperLimit = 
        values
        |> Seq.head

    values
    |> Seq.skip 1
    |> Seq.iter(fun x -> (PrintIfLess upperLimit x))

    0
open System

[<EntryPoint>]
let main argv = 
    let PrintIfOdd i v = 
        match i with
        | x when i % 2 = 1 -> printfn "%d" v
        | _ -> ()

    [|2;5;3;4;6;7;9;8|]
    |> Array.iteri (fun i v -> (PrintIfOdd i v))

    0
open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/non-divisible-subset

    //Unfinished

    let map (input: string) = input.Split [|' '|] |> Array.map(int64)

    let firstInput = Console.ReadLine() |> string |> map
    let secondInput = Console.ReadLine() |> string |> map

    let size = firstInput.[0] - 1L
    let divider = firstInput.[1] 

    secondInput
    |> Array.filter(fun n ->
        secondInput 
        |> Array.filter(fun v -> n <> v)
        |> Array.filter(fun m -> 
            //printfn "%i %i %i %i" n m (n + m) ((n + m) % divider)
            (n + m) % divider <> 0L
        )
        |> Array.length
        |> (fun n ->
            match n with 
            | _ when n = (secondInput.Length-1) -> true
            | _ -> false
        )
    )
    //|> Array.iter(fun n -> printfn "%i" n)
    |> Array.length
    |> printfn "%i"
 
    0
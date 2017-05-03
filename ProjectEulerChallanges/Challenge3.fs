open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=3

    //let number = 13195L
    let number = 600851475143L
    let sqrt = number |> double |> Math.Sqrt |> int64

    [2L..sqrt]
    |> List.filter(fun n -> number % n = 0L)
    //|> List.iter(fun n -> printfn "%A" n)

    printfn "%s" "Done"

    0 
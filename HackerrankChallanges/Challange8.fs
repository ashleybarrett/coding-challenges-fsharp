open System

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> "" do
            arr <- float buff::arr
            buff <- Console.ReadLine()
    arr |> List.rev

//https://www.hackerrank.com/challenges/fp-list-length

let main =
    let evalulate times input =
        [0..(times-1)]
        |> List.fold (fun x y -> x + (Math.Pow(input, float y)/ float y)) 0.0
        |> printfn "%f" 

    (*let evalulate times input =
        [0..times]
        |> List.fold(fun acc x -> sprintf "%i %d" acc x) 0 
        *)
    let input = read_and_parse()
    let times = input.[0]

    input.[1..]
    |> List.map(fun x -> abs x)
    |> List.iter(fun x -> (evalulate (int times) x)) 

main
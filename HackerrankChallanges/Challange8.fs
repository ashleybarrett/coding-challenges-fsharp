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
        |> List.fold(fun x y -> x + y) 0
        |> printfn "%d" 

    let input = read_and_parse()
    let times = int input.[0]

    input.[1..]
    |> List.iter(fun x -> (evalulate times x)) 

main
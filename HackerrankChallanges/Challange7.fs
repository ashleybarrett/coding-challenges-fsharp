open System

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> "" do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr |> List.rev

//https://www.hackerrank.com/challenges/fp-list-length

let main =    
    let input = read_and_parse()

    input
    |> List.map(fun x -> abs x)
    |> List.iter(fun x -> printfn "%d" x)

main
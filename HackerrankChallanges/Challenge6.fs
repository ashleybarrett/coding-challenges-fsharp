open System

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> "" do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

//https://www.hackerrank.com/challenges/fp-list-length

let main =    
    let input = read_and_parse()

    input
    |> List.map(fun x -> 1)
    |> List.sum
    |> printfn "%d"

main
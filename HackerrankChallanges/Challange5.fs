open System

//https://www.hackerrank.com/challenges/fp-sum-of-odd-elements?h_r=next-challenge&h_v=zen

let isOdd n =
    match n with
    | u when (n % 2) = 0 -> false
    | _ -> true

let f arr =
    arr
    |> List.filter(fun x -> (isOdd x))
    |> List.sum

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr
    //printf "%A" <| f [11;25;18;-1;26;-20;-19;23;-24;-8]

main
open System

//https://www.hackerrank.com/challenges/fp-array-of-n-elements

let f n = 
    [n]

let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%d" (f n).Length

main()

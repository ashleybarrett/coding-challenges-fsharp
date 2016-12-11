open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=4

    let smallestNumber = 100
    let largestNumber = 999

    let palindromeProducts = 
        [
            for x in [smallestNumber..largestNumber] do
            for y in [smallestNumber..largestNumber] do
                yield x * y
        ]
        |> List.filter(
            fun n ->
                let asStr = n.ToString()
                let reversed = new String (Array.rev (asStr.ToCharArray()))
                asStr = reversed
        )
        |> List.sortBy(fun x -> -x)

    printfn "%i" palindromeProducts.[0]

    0 
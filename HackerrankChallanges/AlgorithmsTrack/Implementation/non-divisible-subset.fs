module NonDivisibleSubset

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/non-divisible-subset

    //Unfinished

    let nonDivisor = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int64 |> (fun n -> n.[1])
    let numbers = (Console.ReadLine() |> string).Split [| ' ' |] |> Array.map int64 |> Array.toList
    
    let rec getPerms (numbers: list<int64>) (numberPerms: list<int64>) (count: int) = 

        match count <= numbers.Length with
        | true ->
            let hasNonDiviors =
                numbers.Tail 
                |> List.map(fun x -> 
                    let divisor = numbers.Head + x |> (fun i -> i % nonDivisor)
                    printfn "%i + %i = %i m %i = %i" numbers.Head x (numbers.Head + x) nonDivisor divisor
                    divisor
                )
                |> List.filter(fun x -> x <> 0L)
                |> List.length
                |> (fun x -> x > 0)

            match hasNonDiviors with
            | true -> getPerms (numbers.Tail @ [numbers.Head]) ([numbers.Head]@numberPerms) (count+1)
            | false -> getPerms (numbers.Tail @ [numbers.Head]) numberPerms (count+1)
        | false -> numberPerms |> List.length

    getPerms numbers [] 1 |> printfn "%i"
  
    0
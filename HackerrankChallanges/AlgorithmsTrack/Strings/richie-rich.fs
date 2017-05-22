module RichieRich

open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/richie-rich

    //Unfinished.

    let input = Array.init 2 (fun n -> Console.ReadLine() |> string)
    let numberOfSwaps = input.[0].Split [|' '|] |> Array.item(1) |> int
    let numbers = input.[1].ToCharArray() |> Array.toList |> List.map(System.Char.GetNumericValue >> int)
    
    let halfSize = numbers.Length / 2

    let getLeftSide numbers = numbers |> List.take halfSize
    let getRightSide numbers = numbers |> List.skip halfSize |> List.take halfSize |> List.rev

    let rec createTuples leftSide rightSide tuplePairs =
        match leftSide, rightSide with
        | lh::lt, rh::rt -> (lh,rh)::tuplePairs |> createTuples lt rt 
        | _ -> tuplePairs |> List.rev

    let rec swapsNeededForPalindrome tuplePairs swaps = 
        match tuplePairs with
        | h::t -> (
                    let l, r = fst h, snd h
                    swapsNeededForPalindrome t <| if l <> r then swaps+1 else swaps
                )
        | [] -> swaps

    let rec swapForLargestPalindrome tuplePairs swapsAllowed swapsRemainingForPalindrome largestTuplePairs =
        match tuplePairs with
        | h::t -> (
                    let l, r = fst h, snd h
                    let availableSwaps = swapsAllowed - swapsRemainingForPalindrome
                    
                    match l,r with
                    | _ when l = 9 && r = 9 -> (l,r)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed swapsRemainingForPalindrome
                    | _ when l = 9 || r = 9 -> (9,9)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed (swapsRemainingForPalindrome-1)
                    | _ when l = r && availableSwaps > 1 -> (9,9)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed swapsRemainingForPalindrome
                    | _ when l = r && availableSwaps = 1 -> (l,r)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed swapsRemainingForPalindrome
                    | _ when l <> r && availableSwaps > 1 -> (9,9)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed (swapsRemainingForPalindrome-1)
                    | _ when l <> r && availableSwaps = 1 -> 
                        let largerValue = if l > r then l else r
                        (largerValue,largerValue)::largestTuplePairs |> swapForLargestPalindrome t swapsAllowed (swapsRemainingForPalindrome-1)
            )
        | [] -> largestTuplePairs

    let left = getLeftSide numbers
    let right = getRightSide numbers
    let tuplePairs = createTuples left right []
    let swapsNeeded = swapsNeededForPalindrome tuplePairs 0
    
    printfn "%A" tuplePairs
    printfn "%i" swapsNeeded

    match swapsNeeded > numberOfSwaps with
    | true -> printfn "%i" -1
    | false ->     
        swapForLargestPalindrome tuplePairs numberOfSwaps swapsNeeded [] 
        |> List.rev
        |> List.fold(fun a v -> 
            let h, t = fst v, snd v
            List.concat [[h];a;[t]]
        ) []
        |> List.map(string)
        |> List.reduce(+)
        |> printfn "%s" 

    0
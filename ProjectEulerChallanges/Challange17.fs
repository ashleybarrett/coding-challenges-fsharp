open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=17
    let specialCases = [
        (0, 1, "one");
        (0, 2, "two");
        (0, 3, "three");
        (0, 4, "four");
        (0, 5, "five");
        (0, 6, "six");
        (0, 7, "seven");
        (0, 8, "eight");
        (0, 9, "nine");
        (1, 0, "ten");
        (1, 1, "eleven");
        (1, 2, "tweleve");
        (1, 3, "thirteen");
        (1, 4, "fourteen");
        (1, 5, "fifteen");
        (1, 6, "sixteen");
        (1, 7, "seventeen");
        (1, 8, "eighteen");
        (1, 9, "nineteen");
        (2, 0, "twenty");
        (3, 0, "thirty");
        (4, 0, "forty");
        (5, 0, "fifty");
        (6, 0, "sixty");
        (7, 0, "seventy");
        (8, 0, "eighty");
        (9, 0, "ninety")
    ]

    let getSpecialCase tens units = specialCases |> List.tryFind(fun (t,u,w) -> tens = t && units = u)

    let valueForCase tens units suffix = 
        let specialCase = getSpecialCase tens units
        
        match specialCase with
        | Some (t,u,w) -> w + suffix
        | _ -> "" 

    [1..2]
    |> List.map(fun n -> 
        let numberOfThousands = (int)n / 1000
        let numberOfHundreds = (int)n / 100
        let numberOfTens = (int)(n - (numberOfHundreds * 100)) / 10;
        let numberOfUnits = (int)n % 10;
        //let tensAndUnits = (numberOfTens * 10) + numberOfUnits

        let thousandsString = valueForCase 0 numberOfThousands "thousand"
        let hundredsString = valueForCase 0 numberOfHundreds "hundredand"

        //let tensString = valueForCase numberOfTens 0 ""
        //let unitsString = valueForCase 0 numberOfUnits ""

        let tensAndUnitsString = 
            match getSpecialCase numberOfTens numberOfUnits with
            | Some (t,u,w) -> w
            | _ -> (valueForCase numberOfTens 0 "") + (valueForCase 0 numberOfUnits "")

        [thousandsString;hundredsString;tensAndUnitsString]
        |> String.concat ""
        |> String.length
    )
    //|> List.iter(fun n -> printfn "%s" n)
    |> List.sum
    |> printfn "%i"

    

    0  
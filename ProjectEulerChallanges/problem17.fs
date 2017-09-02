module Problem17

let solution =

    //https://projecteuler.net/problem=17
    
    let ones = [(1, "One");(2, "Two");(3, "Three");(4, "Four");(5, "Five");(6, "Six");(7, "Seven");(8, "Eight");(9, "Nine")]
    let tens = [(1, "Ten");(2, "Twenty");(3, "Thirty");(4, "Forty");(5, "Fifty");(6, "Sixty");(7, "Seventy");(8, "Eighty");(9, "Ninety")]
    let teens = [(11, "Eleven");(12, "Tweleve");(13, "Thirteen");(14, "Fourteen");(15, "Fifteen");(16, "Sixteen");(17, "Seventeen");(18, "Eighteen");(19, "Ninteen")]

    let getWord l n = l |> List.find(fun x -> fst x = n) |> snd

    seq [1..999]
    |> Seq.sumBy(fun x ->
        let numberOfHundreds = (int)x / 100;
        let numberOfTens = (int)(x - (numberOfHundreds * 100)) / 10;
        let numberOfUnits = (int)x % 10;
        let tensAndUnits = (numberOfTens * 10) + numberOfUnits;

        let hundredsWord = 
            match numberOfHundreds, tensAndUnits with 
            | _ when numberOfHundreds > 0 && tensAndUnits = 0 -> getWord ones numberOfHundreds + "hundred"
            | _ when numberOfHundreds > 0 && tensAndUnits > 0 -> getWord ones numberOfHundreds + "hundredand" 
            | _ -> ""

        let tensAndUnitsWord = 
            match numberOfTens, numberOfUnits with 
            | _ when numberOfTens = 1 && numberOfUnits > 0 -> 10 + numberOfUnits |> getWord teens 
            | _ when numberOfTens > 0 && numberOfUnits = 0 -> getWord tens numberOfTens
            | _ when numberOfTens > 0 && numberOfUnits > 0 -> (getWord tens numberOfTens) + (getWord ones numberOfUnits)
            | _ when numberOfTens = 0 && numberOfUnits > 0 -> getWord ones numberOfUnits
            | _ -> ""

        hundredsWord + tensAndUnitsWord |> String.length
    )
    |> (+)11 //1000
    |> printfn "%i"
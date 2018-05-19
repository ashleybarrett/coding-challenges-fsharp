module Problem17
let solution =
    //https://projecteuler.net/problem=17

    let oneToNine = 
        [
            0, ""
            1, "One";
            2, "Two";
            3, "Three";
            4, "Four";
            5, "Five";
            6, "Six";
            7, "Seven";
            8, "Eight";
            9, "Nine";
        ] |> Map.ofSeq

    let elevenToNineteen = 
        [
            11, "Eleven";
            12, "Twelve";
            13, "Thirteen";
            14, "Fourteen";
            15, "Fifteen";
            16, "Sixteen";
            17, "Seventeen";
            18, "Eighteen";
            19, "Nineteen";
        ] |> Map.ofSeq

    let tens = 
        [
            0, "";
            1, "Ten";
            2, "Twenty";
            3, "Thirty";
            4, "Forty";
            5, "Fifty";
            6, "Sixty";
            7, "Seventy";
            8, "Eighty";
            9, "Ninty";
        ] |> Map.ofSeq

    let thousand = "Thousand"
    let hundred = "Hundred"

    let unwrapTryFind number =
        match number with
        | Some n -> n
        | _ -> ""

    let getTensWord tenNumber = tens.TryFind tenNumber |> unwrapTryFind

    let getNumberOfUnitsWord unitNumber = oneToNine.TryFind unitNumber |> unwrapTryFind

    let getTeenWord teenNumber = elevenToNineteen.Item teenNumber

    let getWord number suffix = 
        match number > 0 with
        | true -> 
            let numberOfUnitsWord = getNumberOfUnitsWord number
            sprintf "%s%s" numberOfUnitsWord suffix
        | _ -> ""

    let numberToWords number = 

        match number with
        | n when n > 10 && n < 20 -> getTeenWord n
        | _ ->
            let numberOfThousands = number / 1000
            let numberOfHundred = number / 100
            let numberOfTens = number / 10
            let numberOfUnits = number - (numberOfTens * 10)

            //printfn "%i %i " numberOfTens numberOfUnits

            let housandsWords = getWord numberOfThousands thousand
            let hundredsWords = getWord numberOfHundred hundred
            let tensWords = getTensWord numberOfTens
            let unitWord = getNumberOfUnitsWord numberOfUnits

            sprintf "%s%s%s%s" housandsWords hundredsWords tensWords unitWord

    {1..200}
    |> Seq.map numberToWords
    |> Seq.iter(printfn "%s")
    |> ignore

    0
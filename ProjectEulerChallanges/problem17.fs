module Problem17
let solution =
    //https://projecteuler.net/problem=17

    let oneToTwenty = 
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
            10, "Ten";
            11, "Eleven";
            12, "Twelve";
            13, "Thirteen";
            14, "Fourteen";
            15, "Fifteen";
            16, "Sixteen";
            17, "Seventeen";
            18, "Eighteen";
            19, "Nineteen";
            20, "Twenty";
        ] |> Map.ofList

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
            10, "Hundred"
        ] |> Map.ofSeq

    let thousand = "Thousand"

    let getTensWord tenNumber = tens.Item tenNumber

    let getNumberOfUnits unitNumber = oneToTwenty.Item unitNumber

    let numberToWords number = 
        let numberOfTens = number / 10
        let numberOfUnits = number - (numberOfTens * 10)

        printfn "%i %i " numberOfTens numberOfUnits

        let tensWords = getTensWord numberOfTens
        let unitWord = getNumberOfUnits numberOfUnits

        sprintf "%s%s" tensWords unitWord

    {1..20}
    |> Seq.map numberToWords
    |> Seq.iter(printfn "%s")
    |> ignore

    0
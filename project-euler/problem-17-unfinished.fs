module Problem17
let solution =
    //https://projecteuler.net/problem=17

    let oneToNine = 
        [
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

    {1..5}
    |> Seq.sumBy (fun n -> 
        oneToNine.Item n |> (fun s -> s.Length)
    )
    |> ignore

    0
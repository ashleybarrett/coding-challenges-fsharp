open System

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/the-time-in-words

    let specialCases = dict[
            1, "one";2, "two";3, "three";4, "four";5, "five";6, "six";7, "seven";8, "eight";9, "nine";10, "ten";
            11, "eleven";12, "twelve";13, "thirteen";14, "fourteen";16, "sixteen";17, "seventeen";18, "eighteen";19, "twenty";20, "twenty";
            21, "twenty one";22, "twenty two";23, "twenty three";24, "twenty four";25, "twenty five";26, "twenty six";27, "twenty seven";28, "twenty eight";29, "twenty nine"
        ]

    let getSpecialCase n = specialCases.Item(n)

    let getNextHour hour =
        let plusOne = hour + 1
        match plusOne with
        | plusOne when plusOne > 12 -> 1
        | _ -> plusOne

    let getTimeOnWords hour minute = 
        let minutesLeft = 60 - minute
        let nextHour = getNextHour hour
        
        let hourAsWord = getSpecialCase hour
        let nextHourAsWord = getSpecialCase nextHour

        match minute with
        | 0 -> sprintf "%s o' clock" hourAsWord
        | 1 -> sprintf "one minute past %s" hourAsWord
        | 15 -> sprintf "quarter past %s" hourAsWord
        | 30 -> sprintf "half past %s" hourAsWord
        | 45 -> sprintf "quarter to %s" nextHourAsWord
        | _ when minutesLeft < 30 -> sprintf "%s minutes to %s" (getSpecialCase minutesLeft) nextHourAsWord
        | _ when minutesLeft > 30 -> sprintf "%s minutes past %s" (getSpecialCase minute) hourAsWord

    let hour = Console.ReadLine() |> string |> int
    let minute = Console.ReadLine() |> string |> int

    getTimeOnWords hour minute |> printfn "%s"

    0
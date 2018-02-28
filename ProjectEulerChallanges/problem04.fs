module Problem03

let solution =
    //https://projecteuler.net/problem=4

    let uppernumber = 999
    let lowerNumber = 100

    let isPalindrome number = 
        let numberAsString = number |> string
        
        let numberAsStringRev = 
            numberAsString 
            |> Seq.map(string)
            |> Seq.rev 
            |> String.concat ""
        
        numberAsString = numberAsStringRev

    seq { 
        for first in lowerNumber .. uppernumber do
        for second in lowerNumber .. uppernumber do 
            yield first * second
     }
     |> Seq.filter(isPalindrome)
     |> Seq.max



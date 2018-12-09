module ProjectEulerChallenge06

let solution =
    //https://projecteuler.net/problem=6

    let lowerNumber = 1
    let uppernumber = 100

    let getSumOfSquares lowerNumber upperNumber = 
        { lowerNumber .. upperNumber }
        |> Seq.sumBy(fun x -> x * x)
    
    let getSquareOfSum lowerNumber upperNumber =
       { lowerNumber .. upperNumber }
       |> Seq.sum
       |> (fun x -> x * x)

    let sumOfSquares = getSumOfSquares lowerNumber uppernumber
    let squareOfSum = getSquareOfSum lowerNumber uppernumber

    abs (sumOfSquares - squareOfSum)



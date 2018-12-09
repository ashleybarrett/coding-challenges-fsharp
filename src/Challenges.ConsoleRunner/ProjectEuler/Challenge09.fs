module ProjectEulerChallenge09

let solution =
    //https://projecteuler.net/problem=9

    let targetNumber = 1000

    let getNumberSquared number = number * number

    let isPythagoreanTriplet a b c = 
        let aSquared = getNumberSquared a
        let bSquared = getNumberSquared b
        let cSquared = getNumberSquared c 

        a < b && b < c && aSquared + bSquared = cSquared

    seq {
        for a in 1 .. targetNumber do
        for b in 2 .. targetNumber do
        for c in 3 .. targetNumber do
            match isPythagoreanTriplet a b c with        
            | true -> yield (a + b + c, a * b * c)
            | false -> ()
    }
    |> Seq.find(fun x -> x |> fst = 1000)
    |> snd
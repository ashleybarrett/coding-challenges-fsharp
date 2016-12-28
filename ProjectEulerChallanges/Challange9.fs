open System

[<EntryPoint>]
let main argv = 
    
    //https://projecteuler.net/problem=9

    let squared n = n * n 

    let number = 1000

    let triple m n =
        let mSquared = squared m
        let nSquared = squared n
        
        let a = mSquared - nSquared 
        let b = (m*n) * 2 
        let c = mSquared + nSquared 

        (a,b,c)

    let isTriple (a,b,c) = (squared a) + (squared b) = (squared c) 

    let isCandidate (a,b,c) = a+b+c = number


    let a, b, c = 
        [for m in [2..number] do
                for n in [2..m] do
                    yield triple m n] 
        |> List.filter(fun (a,b,c) -> isTriple (a,b,c))
        |> List.find(fun (a,b,c) -> isCandidate (a,b,c))

    printfn "%d" <| a*b*c

    0 
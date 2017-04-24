open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=25
    
    List.unfold(fun (current, next) ->  
        //printfn "%A %A" current next
        let total = current + next
        let lengthAsString = total.ToString()
        if lengthAsString.Length <= 1000 then Some(current,(next, total)) else None
    ) (1I,1I) 
    |> List.length
    //|> (-)1
    |> printfn "%i"

    0  
open System

[<EntryPoint>]
let main argv = 

    //https://projecteuler.net/problem=25
    
    List.unfold(fun (current,total) ->  
        if current > 20 then None else Some(current,(current+1,total+current))) (1,0) 
    |> List.rev
    |> List.head
    |> printf "%i"

    0  
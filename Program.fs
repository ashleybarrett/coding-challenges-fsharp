// Learn more about F# at http://fsharp.org

open System

let SayHello me = printfn "Hello %s" me

let Square num = num * num

[<EntryPoint>]
let main argv = 
    SayHello "Ash"
    let res = Square 6
    res = 1
    printfn "%i" res
    0 // return an integer exit code

// Learn more about F# at http://fsharp.org

open System

type Shape = 
    | Circle of float 
    | Square  of float
    | Rectangle of float * float
    
let pi = 3.141592654

let findArea shape = 
    let area = 
        match shape with
        | Circle f -> pi * f * f
        | Square f -> f * f
        | Rectangle (h, w)  -> h * w
    printfn "%g" area

[<EntryPoint>]
let main argv = 
    let circle = Circle 12.5
    let square = Square 4.0
    let rect = Rectangle (45.3, 12.1)

    //printfn "%g" (findArea circle)
    //printfn "%g" (findArea square)
    //printfn "%g" (findArea rect)

    findArea circle
    findArea square
    findArea rect

    0 // return an integer exit code

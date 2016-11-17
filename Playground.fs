// Learn more about F# at http://fsharp.org

open System

let Sqrs arr =
    let Sqr num = num * num
    [ for num in arr do yield Sqr num ]

let IsEven num = num % 2 = 0

type GeoCoord = { lat: int; long: int; named:string option }

let PrintGeoCord geoCoord = 
    let name = 
        match geoCoord.named with
        | Some n -> n
        | None -> "Not sure"
    printfn "%i %i %s" geoCoord.lat geoCoord.long name     

[<EntryPoint>]
let main argv = 

    Sqrs [|1..100|]    
    |> List.filter IsEven
    |> List.iter(fun x -> printfn "%i" x)

    { lat = 1; long = 2; named = Some "London" } |> PrintGeoCord

    { lat = 1; long = 2; named = None } |> PrintGeoCord

    0 // return an integer exit code

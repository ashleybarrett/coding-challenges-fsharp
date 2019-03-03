module AdventOfCodeYear2018Day06Challenge

open Types
open FileInputProvider

type Point = { x:int; y:int; id:string; nearest:string }

let solution = 

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day06/Test-Input.txt"

    let mapInputsAsPoints = 
        readInput filePath
        |> Array.map(fun x -> 
            let mapToInt (s: string) = s.Trim() |> int

            let parts = x.Split ','

            (parts.[0] |> mapToInt, parts.[1] |> mapToInt)
        )

    let buildGridOfCloestPoints points = 
        let getPointId pointX pointY = sprintf "%i %i" pointX pointY

        let calculateManhattanDistance pointX pointY candidateX candidateY = 
            let xAbs = pointX - candidateX |> abs
            let yAbs = pointY - candidateY |> abs

            xAbs + yAbs

        let getNearestDistance (points: (int * int)[]) pointX pointY =
            let xxx = 
                points
                |> Array.map(fun s -> 
                    let x = fst s
                    let y = snd s

                    let distance = calculateManhattanDistance y pointY x pointX
                    let id = getPointId x y

                    (id, distance)
                )

            xxx
            |> Array.minBy snd
            |> fst

        let calulcateDimension points = points |> Array.max |> (fun x -> x + 1)

        let isPoint (points: (int * int)[]) pointX pointY = points |> Array.exists(fun x -> fst x  = pointX && snd x = pointY)

        let maxWidth = points |> Array.map fst |> calulcateDimension
        let maxHeight = points |> Array.map snd |> calulcateDimension

        seq {
            for w in 0 .. maxWidth do
            for h in 0 .. maxHeight do
                let id = sprintf "%i %i" w h

                match isPoint points w h with
                | true -> yield {x = w; y = h; id = id; nearest = id}
                | _ -> 
                    let nearestDistance = getNearestDistance points w h
                    yield {x = w; y = h; id = id; nearest = nearestDistance}
        }
        |> Seq.toArray

    let partOneSolved =
        let points = mapInputsAsPoints

        let grid = buildGridOfCloestPoints points

        0
    0

module AdventOfCodeYear2018Day03Challenge01

open System.IO
open System

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day03/Input.txt"

    let fibric : int[,] = Array2D.zeroCreate 1000 1000

    let mapToClaim (stringClaim: string) = 
      stringClaim.Split [|'@'|]
      |> Array.last
      |> (fun x -> x.ToCharArray() |> Array.map string)
      |> Array.filter(fun x -> 
        let canParse, _ = Int32.TryParse(x)
        canParse
      )
      |> Array.map int
      |> (fun x -> 
        let xFinishIndex = (x.[0] + x.[2]) - 1
        let yFinishIndex = (x.[1] + x.[3]) - 1

        seq {
          for yIndex in x.[1] .. yFinishIndex do
          for xIndex in x.[0] .. xFinishIndex do
            yield (yIndex, xIndex)
        } 
        |> Seq.toList
      )

    //File.ReadAllLines(filePath)
    //|> Array.toList
    ["#1 @ 1,3: 4x4";"#2 @ 3,1: 4x4";"#3 @ 5,5: 2x2"]
    |> List.map( fun x -> mapToClaim x)
    |> List.collect id
    |> List.iter(fun (x, y) -> 
      let cur = fibric.[y,x]
      fibric.[y,x] <- cur + 1
    )
    
    fibric
    |> Seq.cast<int> 
    |> Seq.filter(fun x -> x > 1)
    |> Seq.length

    

    0
    
    
module AdventOfCodeYear2018Day02Challenge01

open System.IO

let solution =

    let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day02/Input.txt"

    let countsByRepeat input repeat = 
      input
      |> Seq.sumBy(fun x ->
        x
        |> Seq.exists(fun e -> e = repeat) 
        |> (fun m -> if m then 1 else 0)
      )

    let getFileLinesMapped = 
      File.ReadAllLines(filePath)
      |> Seq.map(fun x ->
          x.ToCharArray()
          |> Seq.countBy(id)
          |> Seq.map snd
      )

    let fileLinesMapped = getFileLinesMapped

    countsByRepeat fileLinesMapped 2 * countsByRepeat fileLinesMapped 3
    
    
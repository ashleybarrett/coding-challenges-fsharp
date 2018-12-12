module AdventOfCodeYear2018Day02Challenge02

open System.IO

let solution =

  let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day02/Input.txt"

  let fileLinesMapped = File.ReadAllLines(filePath)
  let halfLength = (fileLinesMapped |> Seq.length) / 2
  let boxIdLength = fileLinesMapped |> Seq.head |> String.length
 
  let mapToStringArray (a:string) = a.ToCharArray() |> Array.map string

  seq {
      for outer in fileLinesMapped |> Seq.take halfLength do
      for inner in fileLinesMapped do
        match outer <> inner with
        | true -> yield (mapToStringArray outer, mapToStringArray inner)
        | _ -> ()
  }
  |> Seq.map(fun (o, i) ->
    o
    |> Array.zip i
    |> Array.filter(fun (a, b) -> a = b)
    |> Array.map fst
  )
  |> Seq.filter(fun x -> boxIdLength - (Array.length x) = 1)
  |> Seq.head
  |> String.concat ""


    



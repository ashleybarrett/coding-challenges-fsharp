module AdventOfCodeYear2018Day02Challenge02

open System.IO

let solution =

  let filePath = "src/Challenges.ConsoleRunner/AdventOfCode/2018/Day02/Input.txt"

  let boxIds = File.ReadAllLines(filePath)
  let boxIdsHalfLength = (boxIds |> Seq.length) / 2
  let boxIdLength = boxIds |> Seq.head |> String.length
 
  let mapToStringArray (a:string) = a.ToCharArray() |> Array.map string

  seq {
      for outer in boxIds |> Seq.take boxIdsHalfLength do
      for inner in boxIds do
        match outer <> inner with
        | true -> yield (mapToStringArray outer, mapToStringArray inner)
        | _ -> ()
  }
  |> Seq.map(fun (o, i) ->
    o
    |> Array.zip i
    |> Array.filter(fun (l, r) -> l = r)
    |> Array.map fst
  )
  |> Seq.filter(fun x -> boxIdLength - (Array.length x) = 1)
  |> Seq.head
  |> String.concat ""


    



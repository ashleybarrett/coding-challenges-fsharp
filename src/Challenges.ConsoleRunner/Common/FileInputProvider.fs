module FileInputProvider

open System.IO

let private readInput filePath = File.ReadAllLines filePath
let readInputAndMapToInts filePath = readInput filePath |> Array.map int
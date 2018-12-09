module FileProvider

open System.IO

let getAllLinesInFile filePath = File.ReadAllLines(filePath)
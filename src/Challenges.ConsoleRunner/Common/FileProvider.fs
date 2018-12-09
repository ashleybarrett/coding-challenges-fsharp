module FileProvider

open System.IO

let getAllLinesInFile filePath = File.ReadLines(filePath)
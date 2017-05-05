open System

type TestCase = { 
    columnsRows: int * int;
    grid: int[][];
    patternColumnsRows: int * int;
    patternGrid: int[][];
}

[<EntryPoint>]
let main argv = 

    //https://www.hackerrank.com/challenges/the-grid-search

    //Unfinished

    let numberOfTestCases = Console.ReadLine() |> int

    let mapArray (s:string) = s.Split [|' '|] |> Array.map(int)

    let generateTestCase = 
        let columnsAndRows = Console.ReadLine() |> string |> mapArray
        let grid = Array.init columnsAndRows.[1] (fun n ->
           Console.ReadLine() |> string |> mapArray 
        )

        let patternColumnsRows = Console.ReadLine() |> string |> mapArray
        let patternGrid = Array.init patternColumnsRows.[1] (fun n ->
           Console.ReadLine() |> string |> mapArray 
        )

        { 
            columnsRows= (columnsAndRows.[0],columnsAndRows.[1]);
            grid= grid;
            patternColumnsRows= (patternColumnsRows.[0],patternColumnsRows.[1]);
            patternGrid= patternGrid;
        }
        
    let testCases = Array.init numberOfTestCases (fun n -> generateTestCase)

    printfn "%A" testCases

    0
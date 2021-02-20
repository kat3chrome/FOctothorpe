// Посчитать значение дерева разбора арифметического выражения, 
// заданного через вложенные discriminated union-ы.

module main
open System
    type Tree =
        | Number of int
        | Addition of Tree * Tree
        | Subtraction of Tree * Tree
        | Multiplication of Tree * Tree
        | Division of Tree * Tree


    let rec Count tree =
        match tree with 
        | Number number -> number
        | Addition(operand1, operand2) -> (Count operand1) + (Count operand2)
        | Subtraction(operand1, operand2) -> (Count operand1) - (Count operand2);
        | Multiplication(operand1, operand2) -> (Count operand1) * (Count operand2)
        | Division(_, operand2) when operand2 = Number 0 -> raise (System.DivideByZeroException())
        | Division(operand1, operand2) -> (Count operand1) / (Count operand2)

    [<EntryPoint>]
    let main argv =
        let tree = Division(Multiplication(Addition(Number 1, Number 2), Subtraction(Number 3, Number 4)), Number -1)
        printfn "%A" tree
        printfn "%A" (Count tree)
        0 

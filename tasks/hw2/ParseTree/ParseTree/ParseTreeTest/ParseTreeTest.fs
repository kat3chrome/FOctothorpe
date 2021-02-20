module ParseTreeTest

open NUnit.Framework
open FsUnit
open main
open System

[<Test>]
let ``Count (1 + 2) * (3 - 4) / (-1) which should equal 3`` () =
    let tree = Division(Multiplication(Addition(Number 1, Number 2), Subtraction(Number 3, Number 4)), Number -1)
    Count tree |> should equal 3

[<Test>]
let ``Division by 0`` () =
    let tree = Division(Number 1, Number 0)
    (fun() -> Count tree |> ignore) |> should throw typeof<System.DivideByZeroException>

open Square
open NUnit.Framework
open FsUnit

[<Test>]
let ``Generate square with N == 1`` () =
    generateSquare 1 |> should equal "*"

[<Test>]
let ``Generate square with N == 2`` () =
    generateSquare 2 |> should equal "**\n**"

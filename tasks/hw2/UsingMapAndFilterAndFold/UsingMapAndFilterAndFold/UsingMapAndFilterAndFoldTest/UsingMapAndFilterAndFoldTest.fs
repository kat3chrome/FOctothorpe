module UsingMapAndFilterAndFoldTest

open NUnit.Framework
open FsUnit
open FsCheck.NUnit
open main

[<Test>]
let ``even countin with map that should equal 10`` () =
    evenCountinWithMap [1; 2; 3; -1; 2; 3; 4; 5; 6] |> should equal 4

[<Test>]
let ``even countin with filter that should equal 10`` () =
    evenCountinWithFilter [1; 2; 3; -1; 2; 3; 4; 5; 6] |> should equal 4

[<Test>]
let ``even countin with fold that should equal 10`` () =
    evenCountinWithFold [1; 2; 3; -1; 2; 3; 4; 5; 6] |> should equal 4

[<Property>]
let ``Compare map and filter counter``(testList:list<int>) =
  evenCountinWithMap testList = evenCountinWithFilter testList

[<Property>]
let ``Compare map and fold counter``(testList:list<int>) =
  evenCountinWithMap testList = evenCountinWithFold testList

[<Property>]
let ``Compare filter and fold counter``(testList:list<int>) =
  evenCountinWithFilter testList = evenCountinWithFold testList

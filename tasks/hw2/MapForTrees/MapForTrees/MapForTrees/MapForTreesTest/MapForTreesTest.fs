module MapForTreesTest

open NUnit.Framework
open FsUnit
open FsCheck.NUnit
open main

[<Test>]
let ``Test mapForTree with function which squares the values`` () =
    let treeInput = Tree (1, Tree (2, Leaf 4, Leaf 5), Tree (3, Leaf 6, Leaf 7))
    let treeResult = Tree (1, Tree (4, Leaf 16, Leaf 25), Tree (9, Leaf 36, Leaf 49))
    mapForTree (fun x -> x * x) treeInput |> should equal treeResult

[<Property>]
let ``Checking the stability of a function, that the values are equal for equal trees``(testTree:Tree<int>) =
    mapForTree (fun x -> x + 1) testTree = mapForTree (fun x -> x + 1) testTree
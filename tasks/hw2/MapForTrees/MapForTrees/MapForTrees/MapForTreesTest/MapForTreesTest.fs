module MapForTreesTest

open NUnit.Framework
open FsUnit
open FsCheck.NUnit
open Main

[<Test>]
let ``Test mapForTree with function which squares the values`` () =
    let treeInput = TreeTwoChild (1, TreeTwoChild (2, Leaf 4, Leaf 5), TreeTwoChild (3, Leaf 6, Leaf 7))
    let treeResult = TreeTwoChild (1, TreeTwoChild (4, Leaf 16, Leaf 25), TreeTwoChild (9, Leaf 36, Leaf 49))
    mapForTree (fun x -> x * x) treeInput |> should equal treeResult
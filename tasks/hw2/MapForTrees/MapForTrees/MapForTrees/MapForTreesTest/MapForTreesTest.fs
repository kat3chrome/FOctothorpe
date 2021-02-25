module MapForTreesTest

open NUnit.Framework
open FsUnit
open Main


[<Test>]
let ``Test mapForTree with function which squares the values`` () =
    let treeInput = TreeTwoChild (1, TreeTwoChild (2, Leaf 4, Leaf 5), TreeTwoChild (3, Leaf 6, Leaf 7))
    let treeResult = TreeTwoChild (1, TreeTwoChild (4, Leaf 16, Leaf 25), TreeTwoChild (9, Leaf 36, Leaf 49))
    mapForTree (fun x -> x * x) treeInput |> should equal treeResult

[<Test>]
let ``Test mapForTree with function which subtracts 1 from values`` () =
    let treeInput = TreeTwoChild (1, TreeOneChild (2, TreeTwoChild (3, Leaf 6, Leaf 7)), TreeTwoChild (3, Leaf 6, Leaf 7))
    let treeResult = TreeTwoChild (0, TreeOneChild (1, TreeTwoChild (2, Leaf 5, Leaf 6)), TreeTwoChild (2, Leaf 5, Leaf 6))
    mapForTree (fun x -> x - 1) treeInput |> should equal treeResult

[<Test>]
let ``Test mapForTree with function which doubles strings in values`` () =
    let treeInput = TreeTwoChild ("a", Leaf "b", Leaf "c")
    let treeResult = TreeTwoChild ("aa", Leaf "bb", Leaf "cc")
    mapForTree (fun x -> x + x) treeInput |> should equal treeResult
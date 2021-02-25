module MapForTreesTest

open NUnit.Framework
open FsUnit
open Main


[<Test>]
let ``Test mapForTree with function which squares the values`` () =
    let treeInput = Node (1, Node (2, Node(4, Empty, Empty),  Node (5, Empty, Empty)), Node (3,  Node (6, Empty, Empty),  Node (7, Empty, Empty)))
    let treeResult = Node (1, Node (4,  Node (16, Empty, Empty),  Node (25, Empty, Empty)), Node (9,  Node (36, Empty, Empty),  Node(49, Empty, Empty)))
    mapForTree (fun x -> x * x) treeInput |> should equal treeResult

[<Test>]
let ``Test mapForTree with function which subtracts 1 from values`` () =
    let treeInput = Node (1, Node (2, Node(4, Empty, Empty),  Node (5, Empty, Empty)), Node (3,  Node (6, Empty, Empty),  Node (7, Empty, Empty)))
    let treeResult = Node (0, Node (1, Node(3, Empty, Empty),  Node (4, Empty, Empty)), Node (2,  Node (5, Empty, Empty),  Node (6, Empty, Empty)))
    mapForTree (fun x -> x - 1) treeInput |> should equal treeResult

[<Test>]
let ``Test mapForTree with function which doubles strings in values`` () =
    let treeInput = Node ("a", Node ("b", Empty, Empty),  Node ("c", Empty, Empty))
    let treeResult = Node ("aa", Node ("bb", Empty, Empty),  Node ("cc", Empty, Empty))
    mapForTree (fun x -> x + x) treeInput |> should equal treeResult
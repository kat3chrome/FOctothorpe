open PointFree
open NUnit.Framework
open FsUnit
open FsCheck.NUnit

[<Test>]
let ``Inital function should work correct`` () =
   func 2 [1..10] |> should equal [2; 4; 6; 8; 10; 12; 14; 16; 18; 20]

[<Test>]
let ``Meta function should work correct`` () =
   funcMeta 2 [1..10] |> should equal [2; 4; 6; 8; 10; 12; 14; 16; 18; 20]

[<Test>]
let ``Result function should work correct`` () =
   (List.map << (*)) 2 [1..10] |> should equal [2; 4; 6; 8; 10; 12; 14; 16; 18; 20]

[<Property>]
let ``Comparing inital and result function with FsCheck`` (value:int, input_list:list<int>) =        
    (func value input_list) = ((List.map << (*)) value input_list)
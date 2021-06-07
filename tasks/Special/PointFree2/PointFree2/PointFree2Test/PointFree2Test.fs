module PointFree2Test

open NUnit.Framework    
open FsCheck.NUnit 
open FsUnit
open Main

[<Test>]
let ``Check that initial function is correct`` () =
    let fun' = fun x -> x * 2
    let l = [1;2;3]
    f fun' l |> should equal [4;6]

[<Test>]
let ``Chech that final function is correct`` () =
    let fun' = fun x -> x * 2
    let l = [1;2;3]
    (((>>) List.tail) << List.map) fun' l |> should equal [4;6]

[<Test>]
let ``Chech that initial and final functions are same`` () =
    let fun' = fun x -> x + x * 10
    let l = [1;2;3]
    (((>>) List.tail) << List.map) fun' l |> should equal <| f fun' l

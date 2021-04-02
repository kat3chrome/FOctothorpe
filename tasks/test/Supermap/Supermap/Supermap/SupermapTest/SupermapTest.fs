open Supermap
open NUnit.Framework
open FsUnit

[<Test>]
let ``Test that supermap [1; 2] (fun x -> [x + 1; x - 1]) get [2, 0, 3, 1]`` () =
    supermap [1; 2] (fun x -> [x + 1; x - 1]) |> should equal [2; 0; 3; 1]

[<Test>]
let ``Test that supermap ["1"; "2"] (fun x -> [x + "a"; x + "b"; x + "c"]) get ["1a", "1b", "1c", "2a", "2b", "2c"]`` () =
    supermap ["1"; "2"] (fun x -> [x + "a"; x + "b"; x + "c"]) |> should equal ["1a"; "1b"; "1c"; "2a"; "2b"; "2c"]
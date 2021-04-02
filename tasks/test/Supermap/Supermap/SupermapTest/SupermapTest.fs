open Supermap
open NUnit.Framework
open FsUnit

[<Test>]
let ``Test that supermap [1; 2] (fun x -> [x + 1; x - 1]) get [2, 0, 3, 1]`` () =
    Assert.That(supermap [1; 2] (fun x -> [x + 1; x - 1]), Is.EqualTo([2; 0; 3; 1]))

[<Test>]
let ``Test that supermap ["1"; "2"] (fun x -> [x + "a"; x + "b"; x + "c"]) get ["1a", "1b", "1c", "2a", "2b", "2c"]`` () =
    Assert.That(supermap ["1"; "2"] (fun x -> [x + "a"; x + "b"; x + "c"]), Is.EqualTo(["1a"; "1b"; "1c"; "2a"; "2b"; "2c"]))
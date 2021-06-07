module stringToMultiplicationTest

open Multiplication
open NUnit.Framework
open FsUnit

[<Test>]
let ``"1" -> 1`` () =
   multiply "1" |> should equal (Some(1))

[<Test>]
let ``"" -> 1`` () =
   multiply "" |> should equal (Some(1))

[<Test>]
let ``"asd" -> None`` () =
   multiply "asd" |> should equal (None)

[<Test>]
let ``"-1" -> None`` () =
   multiply "-1" |> should equal (None)
module BracketSequenceTest

open BracketSequence
open NUnit.Framework

[<Test>]
let ``() should be correct`` () =
    Assert.IsTrue(isCorrectBracketSequence "()")

[<Test>]
let ``([(){}][[{}]][]()) should be correct`` () =
    Assert.IsTrue(isCorrectBracketSequence "([(){}][[{}]][]())")

[<Test>]
let ``([)] should not be correct`` () =
    Assert.IsFalse(isCorrectBracketSequence "([)]")

[<Test>]
let ``42 should not be correct`` () =
    Assert.IsFalse(isCorrectBracketSequence "42")

[<Test>]
let ``empty string should be correct`` () =
    Assert.IsTrue(isCorrectBracketSequence "")
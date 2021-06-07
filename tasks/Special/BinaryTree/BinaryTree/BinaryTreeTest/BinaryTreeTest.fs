module BinaryTreeTest

open BinaryTree
open NUnit.Framework
open FsUnit

[<Test>]
let ``Check that the correct tree is obtained from the [5;1;6]`` () =
    let tree = createTree [5;1;6]
    tree |> should equal { Value = 5;
                            Left = Some { Value = 1;
                                          Left = None;
                                          Right = None };
                            Right = Some { Value = 6;
                                           Left = None;
                                           Right = None; } }

[<Test>]
let ``Check that the correct tree is obtained from the [5;1;6;3;9;0]`` () =
    let tree = createTree [5;1;6;3;9;0]
    tree |> should equal { Value = 5;
                            Left = Some { Value = 1;
                                          Left = Some { Value = 0;
                                                        Left = None
                                                        Right = None; };
                                          Right = Some { Value = 3;
                                                         Left = None;
                                                         Right = None; } };
                            Right = Some { Value = 6;
                                           Left = None;
                                           Right = Some { Value = 9;
                                                          Left = None;
                                                          Right = None; } } }

[<Test>]
let ``Check that enumerator works correct`` () =
    let tree = createTree [5;1;6]
    [ for i in tree -> i ] |> should equal [1;5;6]

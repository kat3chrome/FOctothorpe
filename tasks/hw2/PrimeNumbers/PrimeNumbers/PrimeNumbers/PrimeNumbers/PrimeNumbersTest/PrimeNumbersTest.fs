module PrimeNumbersTest

open NUnit.Framework
open FsUnit
open main

[<Test>]
let ``Test that 104723 exist in sequence and has index 9999`` () =
     (sequenceOfPrimes () |> Seq.findIndex(fun i -> i = 104723)) |> should equal 9999

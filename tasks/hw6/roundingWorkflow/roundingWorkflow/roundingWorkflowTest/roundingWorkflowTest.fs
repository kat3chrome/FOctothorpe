
open roundingWorkflow
open NUnit.Framework
open FsUnit

[<Test>]
let ``((2.0 / 12.0) / 3.5) with rounding 3 should equal 0.048`` () =
    rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    } |> should equal 0.048

[<Test>]
let ``(0.01 + 0.01 with rounding 1 should equal 0`` () =
    rounding 1 {
        return 0.01 + 0.01
    } |> should equal 0

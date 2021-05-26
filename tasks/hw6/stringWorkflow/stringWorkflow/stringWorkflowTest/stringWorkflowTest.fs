open stringWorkflow
open NUnit.Framework
open FsUnit

[<Test>]
let ``"1" + "2" should equal Some(3)`` () =
    Calculator() {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    } |> should equal <| Some(3)

[<Test>]
let ``"1" + "Ъ" should equal None`` () =
    Calculator() {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    } |> should equal <| None
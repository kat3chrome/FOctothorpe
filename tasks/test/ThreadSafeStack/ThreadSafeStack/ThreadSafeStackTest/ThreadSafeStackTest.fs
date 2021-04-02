open ThreadSafeStack
open FsUnit
open NUnit.Framework


[<Test>]
let ``Test push and pop with int`` () =
    let stack = new ThreadSafeStack<int>()
    stack.Push 1
    stack.Pop() |> should equal (Some 1)

[<Test>]
let ``Test push and pop with string`` () =
    let stack = new ThreadSafeStack<string>()
    stack.Push "1"
    stack.Pop () |> should equal (Some "1")

[<Test>]
let ``Test pop with empty stack`` () =
    let stack = new ThreadSafeStack<int>()
    stack.Pop () |> should equal None
module BracketSequence

open System.Collections.Generic

// Get a reverse bracket
let getOpenBracket bracket =
    match bracket with 
    | '(' -> ')'
    | '[' -> ']'
    | '{' -> '}'
    | _ -> failwith "[ERROR] unknown symbol"

// Check is the bracket a open bracket
let isOpenBracket bracket =
    match bracket with
    | '['|'{'|'(' -> true
    | _ -> false

// Check is sequence of brackets a correct
let isCorrectBracketSequence input =
    let sequence = Seq.toList input

    let rec loop subsequence (stack:Stack<char>) =
        match subsequence with
        | h :: t when isOpenBracket h ->
            stack.Push(h)
            loop t stack
        | h :: _ when stack.Count > 0 && getOpenBracket (stack.Peek()) <> h -> false
        | h :: t when stack.Count > 0 && getOpenBracket (stack.Pop()) = h -> loop t stack
        | [] when stack.Count = 0 -> true
        | _ -> false
    loop sequence (Stack<char>())

printfn "%A" (isCorrectBracketSequence "([]){}")

module BracketSequence


/// Get a reverse bracket
let getOpenBracket bracket =
    (Map.ofList [ ('(', ')'); ('[', ']'); ('{', '}') ]).[bracket]

/// Check iп the bracket a open 
let isOpenBracket bracket =
    (Map.ofList [ ('(', ')'); ('[', ']'); ('{', '}') ]).ContainsKey bracket

/// Check if the bracket is an open bracket
let isCorrectBracketSequence input =
    let sequence = Seq.toList input

    let rec loop (subsequence: List<char>) (stack: List<char>) =
        match subsequence, stack with
        | (h :: t, _) when isOpenBracket h ->
            loop t (h :: stack)
        | (h :: _, _) when stack.Length > 0 && getOpenBracket (stack.Head) <> h -> false
        | (h :: t, _ :: stackTail) when stack.Length > 0 && getOpenBracket (stack.Head) = h -> loop t stackTail
        | ([], _) when stack.Length = 0 -> true
        | _ -> false
    loop sequence []

printfn "%A" (isCorrectBracketSequence "([]){}")

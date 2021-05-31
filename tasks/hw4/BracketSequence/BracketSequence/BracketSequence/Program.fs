module BracketSequence

let isCorrectBracketSequence input =
    let brackets = Map.ofList [ ('(', ')'); ('[', ']'); ('{', '}') ]
    let sequence = Seq.toList input

    let rec loop (subsequence: List<char>) (stack: List<char>) =
        match subsequence, stack with
        | (h :: t, _) when brackets.ContainsKey h ->
            loop t (h :: stack)
        | (h :: _, _) when stack.Length > 0 && brackets.[stack.Head] <> h -> false
        | (h :: t, _ :: stackTail) when stack.Length > 0 && brackets.[stack.Head] = h -> loop t stackTail
        | ([], []) -> true
        | _ -> false
    loop sequence []

printfn "%A" (isCorrectBracketSequence "([]){}")

module BracketSequence

/// Checking that the bracket sequence is correct
let isCorrectBracketSequence input =
    let brackets = Map.ofList [ ('(', ')'); ('[', ']'); ('{', '}') ]
    let sequence = Seq.toList input

    let rec loop (subsequence: List<char>) (stack: List<char>) =
        match subsequence, stack with
        | (h :: t, _) when brackets.ContainsKey h ->
            loop t (h :: stack)
        | (h :: _, stackHead :: _) when brackets.[stackHead] <> h -> false
        | (h :: t, stackHead :: stackTail) when brackets.[stackHead] = h -> loop t stackTail
        | ([], []) -> true
        | _ -> false
    loop sequence []

printfn "%A" (isCorrectBracketSequence "([]){}")

module BracketSequence

open System

let isCorrectBracketSequence input =
    let rec loop input = 
        match input:string with
        | input when input.Contains "()" -> loop (input.Replace ("()", ""))
        | input when input.Contains "{}" -> loop (input.Replace ("{}", ""))
        | input when input.Contains "[]" -> loop (input.Replace ("[]", ""))
        | _ -> input
    if (input.Equals "") then false else (loop input).Equals ""

printfn "%A" (isCorrectBracketSequence "([])")

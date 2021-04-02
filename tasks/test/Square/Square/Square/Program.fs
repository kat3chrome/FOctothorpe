
module Square

let generateSquare N = 
    match N with
    | _ when N > 1 -> ((String.replicate N "*") + "\n" + (String.replicate (N - 2) 
                         ("*" + (String.replicate (N - 2) " ") + "*\n")) + (String.replicate N "*"))
    | _ -> "*"

let printSquare N =
    printf "%s\n" (generateSquare N)

printSquare 2


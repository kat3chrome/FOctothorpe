let rec reverse list acc=
    match list with
    | [] -> []
    | [x] -> x::acc
    | head::tail -> reverse tail (head::acc)

let list = [1..1000000]
printf "%A" (reverse list [])
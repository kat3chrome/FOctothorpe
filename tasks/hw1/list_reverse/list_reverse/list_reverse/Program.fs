let rec reverse list =
    let rec reserseSubfunction list acc =
        match list with
        | [] -> []
        | [x] -> x::acc
        | head::tail -> reserseSubfunction tail (head::acc)
    reserseSubfunction list []

let list = [1..1000000]
printf "%A" (reverse list)
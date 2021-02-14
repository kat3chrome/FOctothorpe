let rec reverse list =
    let rec reserseSubfunction list accumulator =
        match list with
        | [] -> []
        | [x] -> x::accumulator
        | head::tail -> reserseSubfunction tail (head::accumulator)
    reserseSubfunction list []

let list = [1..1000000]
printf "%A" (reverse list)
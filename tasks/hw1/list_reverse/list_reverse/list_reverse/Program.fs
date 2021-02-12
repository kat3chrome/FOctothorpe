let rec reverse list =
    match list with
    |[] -> []
    |[x] -> [x]
    |head::tail -> reverse tail @ [head]

let list = [ 1 .. 10 ] @ 12::[5; 7]
printf "%A" (reverse list)
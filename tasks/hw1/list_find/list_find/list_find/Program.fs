let find list value =
    let rec find_subfunction list index =
       match list with
       | head :: tail when head = value -> index
       | head :: tail -> find_subfunction tail (index + 1)
       | [] -> -1
    find_subfunction list 0

printfn "%A" (find [ 1..10 ] 1)
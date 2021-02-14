let find list value =
    let rec findSubfunction list index =
       match list with
       | head :: tail when head = value -> index
       | head :: tail -> findSubfunction tail (index + 1)
       | [] -> -1
    findSubfunction list 0

printfn "%A" (find [ 1..10 ] 1)

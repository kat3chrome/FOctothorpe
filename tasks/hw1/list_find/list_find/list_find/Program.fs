let find list value =
    let rec findSubfunction list index =
       match list with
       | head :: _ when head = value -> Some(index)
       | _ :: tail -> findSubfunction tail (index + 1)
       | [] -> None
    findSubfunction list 0

printfn "%A" (find [ 1..10 ] 10)

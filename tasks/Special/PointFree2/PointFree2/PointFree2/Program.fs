module Main 

/// Initial expression
let f g l = List.map g (List.tail l)
/// Middle expression
let f'1 g  = List.tail >> List.map g 
/// Final expression
let f'2 = ((>>) List.tail) << List.map

f'2 (fun x -> printfn "%A" x) [1; 2; 3] |> ignore
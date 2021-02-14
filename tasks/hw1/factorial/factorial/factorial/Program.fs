open System.Diagnostics

let rec factorial number =
    if number < 0 then 
        failwith $"Incorrect value '{number}'"
    let rec factorialSubfunction index accumulator =
        match index with
        | 0 | 1 -> accumulator
        | _ -> factorialSubfunction (index - 1) (accumulator * index)
    factorialSubfunction number 1

printfn "%A" (factorial 10)
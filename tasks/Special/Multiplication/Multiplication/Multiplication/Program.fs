// Реализовать функцию, которая вычисляет произведение цифр данного числа

module Multiplication

//let stringToMultiplication = Seq.toList >> List.map (fun x -> int x - int '0') >> List.fold (*) 1

let multiply input =
    let rec loop input accumulator =
        match input with
        | h::t when List.contains h [0..9] -> loop t (accumulator * h)
        | [] -> accumulator |> Some
        | _ -> None
    loop (Seq.toList input |> List.map (fun x -> int x - int '0')) 1

printf "%A" (multiply "123")
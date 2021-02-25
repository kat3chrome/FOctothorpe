// Реализовать три варианта функции, подсчитывающей количество четных чисел в списке 
// (с использованием стандартных функций map, filter, fold). Использование рекурсии 
// не допускается, зато нужен FsCheck для проверки функций на эквивалентность.

module Main

    let evenCountinWithMap list = 
        list |> List.map (fun x -> abs((x + 1) % 2)) |> List.sum

    let evenCountinWithFilter list = 
        list |> List.filter (fun x -> x % 2 = 0) |> List.length

    let evenCountinWithFold list = 
        list |> List.fold (fun x y -> x + abs ((y + 1) % 2)) 0

    let list = [-10..10]

    printf "%A\n" (evenCountinWithMap list)

    printf "%A\n" (evenCountinWithFilter list)

    printf "%A\n" (evenCountinWithFold list)
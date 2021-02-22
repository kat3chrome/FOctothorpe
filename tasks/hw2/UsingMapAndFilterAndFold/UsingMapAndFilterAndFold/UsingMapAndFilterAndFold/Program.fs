// Реализовать три варианта функции, подсчитывающей количество четных чисел в списке 
// (с использованием стандартных функций map, filter, fold). Использование рекурсии 
// не допускается, зато нужен FsCheck для проверки функций на эквивалентность.

module main

    let evenCountinWithMap list = 
        List.sum (list |> List.map (fun x -> abs((x + 1) % 2)))

    let evenCountinWithFilter list = 
        List.length (list |> List.filter (fun x -> x % 2 = 0))

    let evenCountinWithFold list = 
        abs((list |> List.fold (fun x y -> x + abs(y % 2)) 0) - List.length list)

    let list = [-10..10]

    printf "%A\n" (evenCountinWithMap list)

    printf "%A\n" (evenCountinWithFilter list)

    printf "%A\n" (evenCountinWithFold list)
let generateListOfTwoPowers n m =
    if n < 1 then
        failwith $"Incorrect value n = '{n}'"
    elif m < 0 then
        failwith $"Incorrect value m = '{m}'"
    elif n > m then
        failwith $"Incorrect values n = '{n}', m = '{m}'"

    let rec generateListOfTwoPowersSubfunction list value index = 
        if index <= m + n then
            generateListOfTwoPowersSubfunction (list @ [value + value]) (value + value) (index + 1)
        else list

    generateListOfTwoPowersSubfunction [] (pown 2 (n - 1)) n

printfn "%A" (generateListOfTwoPowers 4 10)
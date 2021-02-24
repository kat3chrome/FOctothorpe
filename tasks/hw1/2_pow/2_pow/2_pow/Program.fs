let generateListOfTwoPowers n m =
    if n < 1 then
        failwith $"Incorrect value n = '{n}'"
    elif m < 0 then
        failwith $"Incorrect value m = '{m}'"

    let rec generateListOfTwoPowersSubfunction list value index = 
        if index <= m + n then
            generateListOfTwoPowersSubfunction ((value / 2) :: list) (value / 2) (index + 1)
        else list

    generateListOfTwoPowersSubfunction [] (pown 2 (m + n + 1)) n

printfn "%A" (generateListOfTwoPowers 3 5)
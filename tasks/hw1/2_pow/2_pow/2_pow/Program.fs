let generateListOfTwoPowers n m =
    let rec generateListOfTwoPowersSubfunction list index = 
        if index <= m + n then
            generateListOfTwoPowersSubfunction (list @ [(pown 2 index)]) (index + 1)
        else list

    generateListOfTwoPowersSubfunction [] n

printfn "%A" (generateListOfTwoPowers 2 3)
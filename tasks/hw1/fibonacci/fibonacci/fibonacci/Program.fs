let rec countFibonacciByIndex index =
    let rec countFibonacciByIndexSubfunction first second currentIndex = 
        if currentIndex <= index then
            countFibonacciByIndexSubfunction (first + second) first (currentIndex + 1)
        else first
    if index >= 0 then
        countFibonacciByIndexSubfunction 0 1 1
    else raise (System.Exception($"Incorrect index '{index}'"))
    
printfn "%A" (countFibonacciByIndex 10)

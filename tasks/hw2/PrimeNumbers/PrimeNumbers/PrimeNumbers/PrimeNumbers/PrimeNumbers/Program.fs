// Реализовать функцию, генерирующую 
// бесконечную последовательность простых чисел.

module main

    let isPrime n = 
        let bound = int (sqrt (float n))
        seq{2..bound}
        |> Seq.exists (fun x -> n % x = 0) 
        |> not

    let rec nextPrime n = 
        if isPrime (n + 1) then n + 1
        else nextPrime (n + 1)

    let rec sequenceOfPrimes () = Seq.unfold (fun n -> Some(n, nextPrime n)) 1

    printf "%A" (sequenceOfPrimes ())

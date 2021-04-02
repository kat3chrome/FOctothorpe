

let printSquare N =
    printf "%s\n" (String.replicate N "*")
    printf "%s" (String.replicate (N - 2) 
                    ("*" + (String.replicate (N - 2) " ") + "*\n"))
    printf "%s\n" (String.replicate N "*")

printSquare 4


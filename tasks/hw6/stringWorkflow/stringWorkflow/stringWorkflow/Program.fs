module stringWorkflow 

    open System

    type calculate() =
        member this.Bind (n : string, func) =
            let parsedString = Int32.TryParse(n)
            match parsedString with
            | false, _ -> None
            | true, x -> func x

        member this.Return(x) =
            Some(x) 

    calculate () {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    } |> printf "%A\n"

    calculate () {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    } |> printf "%A"
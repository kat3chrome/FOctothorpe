module stringWorkflow 

    open System

    // A workflow that performs calculations on numbers specified as strings.
    type Calculator() =
        member this.Bind (n : string, func) =
            let parsedString = Int32.TryParse(n)
            match parsedString with
            | false, _ -> None
            | true, x -> func x

        member this.Return(x) =
            Some(x) 

    Calculator () {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    } |> printf "%A\n"

    Calculator () {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    } |> printf "%A"
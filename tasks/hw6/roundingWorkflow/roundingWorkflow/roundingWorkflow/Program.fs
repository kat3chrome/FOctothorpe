module roundingWorkflow 

    open System

    type Rounding(accuracy : int) =
        member this.Bind (n : float, func) =
            func (Math.Round(n, accuracy))

        member this.Return (n : float) =
            Math.Round(n, accuracy)

    let result = Rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }
    printf "%A" result
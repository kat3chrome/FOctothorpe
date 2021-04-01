module LazyFactory

open System.Threading

type ILazy<'a> =
    abstract member Get: unit -> 'a

type SingleMode<'a> (supplier) = 
    let mutable result = None
    interface ILazy<'a> with
        member _.Get() = 
            if result.IsSome then 
                result.Value
            else 
                result <- Some(supplier ())
                result.Value
open System
open LazyFactory

let singleMode = (LazyFactory.SingleMode(fun () -> 7) :> ILazy<int>).Get()
printf "%A" singleMode
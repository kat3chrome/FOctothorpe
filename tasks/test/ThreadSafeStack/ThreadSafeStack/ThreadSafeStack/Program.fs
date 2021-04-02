// Learn more about F# at http://fsharp.org

type ThreadSafeStack<'T>() =    
  let mutable stack : List<'T> = []

  member this.Push value =
    lock stack (fun () -> 
      stack <- value::stack)

  member this.Pop() =
    lock stack (fun () ->
      match stack with
      | head::tail ->
          stack <- tail
          Some head
      | [] -> None)
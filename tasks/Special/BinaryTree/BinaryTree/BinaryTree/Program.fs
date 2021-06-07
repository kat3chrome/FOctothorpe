open System
open System.Collections
open System.Collections.Generic

type Tree<'a> = 
    {
        Value: 'a;
        Left: Tree<'a> option;
        Right: Tree<'a> option
    }

    member this.ToSeq() =
        let rec loop = function
            | None -> []
            | Some(node) -> (loop node.Left) @ [node.Value] @ (loop node.Right)
        this |> Some |> loop |> List.toSeq

    interface IEnumerable<'a> with
        member this.GetEnumerator() : IEnumerator<'a> = 
            this.ToSeq().GetEnumerator()
        member this.GetEnumerator() : IEnumerator =
            (this.ToSeq() :> IEnumerable).GetEnumerator()

let createTree items =
    let rec addValue value = function
    | None -> {Value = value; Left = None; Right = None}
    | Some(tree) when value <= tree.Value -> {tree with Left = Some(addValue value tree.Left)}
    | Some(tree) -> {tree with Right = Some(addValue value tree.Right)}

    items |> List.fold (fun tree value -> Some(addValue value tree)) None |> Option.get

let tree = createTree [5;6;7;1]
for i in tree do
    printf "%A " i

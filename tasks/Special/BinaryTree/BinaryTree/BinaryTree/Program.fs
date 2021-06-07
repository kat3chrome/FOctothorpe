module BinaryTree

open System.Collections
open System.Collections.Generic

/// Binary tree
type Tree<'a> = 
    {
        Value: 'a;
        Left: Tree<'a> option;
        Right: Tree<'a> option
    }

    /// Convert tree to seq
    member this.ToSeq() =
        let rec loop = function
            | None -> []
            | Some(node) -> (loop node.Left) @ [node.Value] @ (loop node.Right)
        this |> Some |> loop |> List.toSeq
    
    /// Implementing of IEnumerable
    interface IEnumerable<'a> with
        member this.GetEnumerator() : IEnumerator<'a> = 
            this.ToSeq().GetEnumerator()
        member this.GetEnumerator() : IEnumerator =
            (this.ToSeq() :> IEnumerable).GetEnumerator()

/// Create tree from list
let createTree items =
    let rec addValue value = function
    | None -> {Value = value; Left = None; Right = None}
    | Some(tree) when value <= tree.Value -> {tree with Left = Some(addValue value tree.Left)}
    | Some(tree) -> {tree with Right = Some(addValue value tree.Right)}

    items |> List.fold (fun tree value -> Some(addValue value tree)) None |> Option.get

let tree = createTree [2;1;3]
printfn "%A" tree
for i in tree do
    printf "%A " i

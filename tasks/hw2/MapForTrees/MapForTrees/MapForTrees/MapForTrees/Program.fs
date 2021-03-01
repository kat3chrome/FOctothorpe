// Реализовать функцию, применяющую функцию к каждому элементу двоичного дерева 
// и возвращающую новое двоичное дерево, каждый элемент которого — результат 
// применения функции к соответствующему элементу исходного дерева (map для деревьев).

module Main

    /// Binary tree.
    type Tree<'a> =
        | Node of 'a * Tree<'a> * Tree<'a>
        | Empty

    let rec mapForTree function' tree =
           match tree with
           | Node (value, leftChild, rightChild) -> Node (function' value, mapForTree function' leftChild, mapForTree function' rightChild)
           | Empty -> Empty


    [<EntryPoint>]
    let main argv =
        let tree = Node (1, Node (2, Node (3, Empty, Empty), Empty), Node (3, Empty, Empty))
        printfn "%A" tree
        printfn "%A" (mapForTree (fun x -> x + 1) tree)
        0 
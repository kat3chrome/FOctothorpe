// Реализовать функцию, применяющую функцию к каждому элементу двоичного дерева 
// и возвращающую новое двоичное дерево, каждый элемент которого — результат 
// применения функции к соответствующему элементу исходного дерева (map для деревьев).

module Main

    /// Just a tree.
    type Tree<'a> =
        | TreeTwoChild of 'a * Tree<'a> * Tree<'a>
        | TreeOneChild of 'a * Tree<'a>
        | Leaf of 'a

    let rec mapForTree function' tree =
        match tree with
        | TreeTwoChild(node, leftChild, rightChild) -> TreeTwoChild(function' node, mapForTree function' leftChild, mapForTree function' rightChild)
        | TreeOneChild(node, child) -> TreeOneChild(function' node, mapForTree function' child)
        | Leaf(node) -> Leaf(function' node)

    [<EntryPoint>]
    let main argv =
        let tree = TreeTwoChild (1, TreeOneChild (2, TreeTwoChild (3, Leaf 6, Leaf 7)), TreeTwoChild (3, Leaf 6, Leaf 7))
        printfn "%A" tree
        printfn "%A" (mapForTree (fun x -> x + 1) tree)
        0 
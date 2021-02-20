// Реализовать функцию, применяющую функцию к каждому элементу двоичного дерева 
// и возвращающую новое двоичное дерево, каждый элемент которого — результат 
// применения функции к соответствующему элементу исходного дерева (map для деревьев).

module main

    type Tree<'a> =
        |Tree of 'a * Tree<'a> * Tree<'a>
        |Leaf of 'a

    let rec mapForTree function' tree =
        match tree with
        |Tree(node, leftChild, rightChild) -> Tree(function' node, mapForTree function' leftChild, mapForTree function' rightChild)
        |Leaf(node) -> Leaf(function' node)

    [<EntryPoint>]
    let main argv =
        let tree = Tree (1, Tree (2, Leaf 4, Leaf 5), Tree (3, Leaf 6, Leaf 7))
        printfn "%A" tree
        printfn "%A" (mapForTree (fun x -> x + 1) tree)
        0 
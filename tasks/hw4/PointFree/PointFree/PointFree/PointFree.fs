// Записать в point-free стиле «func x l = List.map (fun y -> y * x) l». 
// Выписать шаги вывода и проверить с помощью FsCheck корректность результата.

module PointFree

let func x l = List.map (fun y -> y * x) l

let funcMeta x  = List.map ((*) x)

let funcResult = List.map << (*)

printf "%A\n" (func 2 [1..10])
printf "%A\n" (funcMeta 2 [1..10])
printf "%A\n" (funcResult 2 [1..10])
module PhoneBookTest

open FsUnit
open PhoneBook
open NUnit.Framework

[<Test>]
let ``addRecord should add record`` () =
    addRecord Map.empty "name" "phone"
    |> Map.filter (fun phone name -> phone = "phone" && name = "name")
    |> should not' (equal Map.empty)

[<Test>]
let ``If record exist, findByPhone should find it`` () =
    addRecord Map.empty "name" "phone"
    |> findByPhone <| "phone"
    |> should not' (equal Map.empty)

[<Test>]
let ``If record exist, findByName should find it`` () =
    addRecord Map.empty "name" "phone"
    |> findByName <| "name"
    |> should not' (equal Map.empty)

[<Test>]
let ``Data from writeContacts -> readContacts should be equal of initial data`` () =
    let phoneBookPath = "phonebookTest.data"
    let rec loop data contacts =
        match data with
        | h::t -> loop t contacts
        | _ -> contacts
    let contacts = loop [("a", "a"), ("b", "b")] Map.empty
    writeContacts phoneBookPath contacts
    readContacts phoneBookPath |> should equal contacts
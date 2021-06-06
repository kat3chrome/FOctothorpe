open System
open System.IO
open System.Text.Json

/// Add record to contacts
let addRecord contacts name phone =
    Map.add phone name contacts

/// Find contacts with a specific phone
let findByPhone contacts phone = 
    Map.filter (fun value _ -> value = phone) contacts

/// Find contacts with a specific name
let findByName contacts name =
    Map.filter (fun _ value -> value = name) contacts

/// Read contacts from a storage
let readContacts phoneBookPath =
    if File.Exists phoneBookPath
    then
        phoneBookPath |> File.ReadAllText |> JsonSerializer.Deserialize |> Map.ofSeq
    else
        Map.empty

/// Write contacts from a storage
let writeContacts phoneBookPath contacts =
    use fileStream = new FileStream(phoneBookPath, FileMode.Create)
    let json = JsonSerializer.SerializeToUtf8Bytes(contacts |> Map.toSeq)
    fileStream.Write(json, 0, json.Length)

/// Pretty print of contracts
let rec printContacts contacts =
    let rec loop contacts = 
        match contacts with
        | (name, number)::t -> 
            printfn "name: '%s' - contact: '%s'" name number
            loop t
        | [] -> ()
    contacts |> Map.toList |> loop
 
/// User interface loop
let UI () =
    let phoneBookPath = "phonebook.data"
    let commands = """1. Exit
2. Add record
3. Find by phone
4. Find by name
5. Get all info
6. Write to file
7. Read from file"""
    printfn "%s" commands

    let rec loop contacts = 
        printf "Enter the command: "
        let input = Console.ReadLine()
        match input with
        | "1" -> 
            printfn "Exit"
            ()
        | "2" -> 
            printf "Enter the name: "
            let name = Console.ReadLine()
            printf "Enter the phone: "
            let phone = Console.ReadLine()
            addRecord contacts name phone |> loop
        | "3" -> 
            printf "Enter the phone: "
            let phone = Console.ReadLine()
            findByPhone contacts phone |> printContacts
            loop contacts
        | "4" ->
            printf "Enter the name: "
            let name = Console.ReadLine()
            findByName contacts name |> printContacts
            loop contacts
        | "5" -> 
            printfn "Contacts:"
            printContacts contacts
            loop contacts
        | "6" -> 
            printfn "Saved"
            writeContacts phoneBookPath contacts 
            loop contacts
        | "7" -> 
            printfn "Read"
            readContacts phoneBookPath |> loop
        | _ -> 
            printfn "Incorrect command"
            loop contacts
    loop Map.empty

UI ()
open Domain
open Operations
[<EntryPoint>]
let main _= 
    let customer:Customer = {FirstName="Sambaran"; LastName="Hazra"; Age=31} 
    let first, last = getInitials customer
    let isOlder = isOlderThan 10 customer
    printfn "The initials are: %c, %c,\nCustomer isOlder? %b" first last isOlder
    0 // return an integer exit code

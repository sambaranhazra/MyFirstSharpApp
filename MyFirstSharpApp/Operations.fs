module Operations

open Domain

let getInitials (customer : Customer) = customer.FirstName.[0], customer.LastName.[0]
let isOlderThan age (customer : Customer) = customer.Age > age

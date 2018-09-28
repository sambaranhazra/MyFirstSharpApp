let getCreditLimit customer = 
    match customer with
    |   "medium", year when year > 1 -> 500
    |   "good", year when year < 2 -> 750
    |   "good", 2 -> 1000
    |   "good", _ -> 2000
    |   _ -> 250

type Customer =
    {Name:string; Balance: int}

let handleCustomers (customers:Customer List) = 
    match customers with
    | []->failwith "No customers supplied"
    | [customer] -> printfn "Single customer, name is %s" customers.Head.Name
    | [customer1; customer2] -> printfn "Two customers, balance %d" (customer1.Balance + customer2.Balance)
    | customers->printfn "Customers supplied %d" customers.Length

let emptyCustomerList = List.empty<Customer>

let singleCustomerList: Customer List = [{Name="Sambaran";Balance=100}]

let twoCustomersList: Customer List = [{Name="Sambaran";Balance=100};{Name="Babai";Balance=100}]

                                        
let threeCustomersList: Customer List = [{Name="Sambaran";Balance=100};{Name="Babai";Balance=100};{Name="Jhunai";Balance=50}]

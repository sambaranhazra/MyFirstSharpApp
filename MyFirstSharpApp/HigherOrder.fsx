module HigherOrder =
    type Customer =
        { Age : int }
    
    let printCustomerAge (customer : Customer) writer =
        if customer.Age <= 10 then writer "Child"
        elif customer.Age <= 18 then writer "Teenager"
        else writer "Adult"
        0
    
    let customer : Customer = { Age = 15 }

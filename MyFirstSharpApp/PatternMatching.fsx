let getCreditLimit customer = 
    match customer with
    |   "medium", 1 -> 500
    |   "good", year when year < 2 -> 750
    |   "good", 2 -> 1000
    |   "good", _ -> 2000
    |   _ -> 250

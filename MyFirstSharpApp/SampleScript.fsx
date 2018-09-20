let greetPerson (name, age) = sprintf "Hello, %s. You are %d years old" name age
let add (first, second) = first + second
let total() = sprintf "Total is : %d" (add (20, 3))
let rand = System.Random()
let callRandom() = sprintf "%d" (rand.Next(5))

let foo() =
    let x = 10
    printfn "%d" (x + 20)
    let x = "test"
    let x = 50.0
    x + 200.0

let estimateAges (familyName, year1, year2, year3) =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth
    
    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3
    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3) / 3
    sprintf "Average age for family %s is %d" familyName averageAge

let getLength (name : string) = sprintf "Name is %d characters long." name.Length

open System.Collections.Generic
open System
open System.IO

let numbers = List<_>()

numbers.Add(10)
numbers.Add(20)

let otherNumbers = List()

otherNumbers.Add(10)
otherNumbers.Add(20)

let sayHello (someValue) =
    let innerFunction (number : int) =
        if number > 10 then "Issac"
        elif number > 20 then "Fred"
        else "Sara"
    
    let resultOfInner =
        if someValue < 10 then innerFunction (5)
        else innerFunction (15)
    
    "Hello " + resultOfInner

let parse (data : string) : string * string * int =
    let items = data.Split(' ')
    let name = items.[0]
    let game = items.[1]
    let score = int (items.[2])
    (name, game, score)

let number = "123"
let result, parsed = Int32.TryParse(number)

type Address =
    { Street : string
      Town : string
      City : string }

type Customer =
    { Forename : string
      Surname : string
      Age : int
      Address : Address
      EmailAddress : string }

let customer =
    { Forename = "Sambaran"
      Surname = "Hazra"
      Age = 31
      Address =
          { Street = "Gear Road"
            Town = "Bhoganhalli"
            City = "Bangalore" }
      EmailAddress = "Sambaran2010@gmail.com" }

customer.Address.City

type Car =
    { Manufacturer : string
      EngineSize : int
      NumberOfDoors : int
      Color : string }

let MyCar =
    { Manufacturer = "Hyundai"
      EngineSize = 898
      NumberOfDoors = 5
      Color = "Blue" }

let MyOldCar = MyCar

let MyAddress : Address =
    { Street = "Gear Road"
      Town = "Bhoganhalli"
      City = "Bangalore" }

let MyNewAddress : Address =
    { Street = "Gear Road"
      Town = "Bhoganhalli"
      City = "Bangalore" }

let MyCurrentAddress = MyAddress

let UpdateCustomerAge(customer : Customer) : Customer =
    let age = System.Random().Next(18, 45)
    printfn "Original Age: %d, New Age: %d" customer.Age age
    { customer with Age = age }

let tupledAdd (a, b) = a + b
let curriedAdd a b = a + b

let writeToFile (date : DateTime) filename text =
    let dateFileName = Directory.GetCurrentDirectory() + "//" + (date.ToString "yyMMdd") + "-" + filename
    System.IO.File.WriteAllText(dateFileName, text)

Directory.GetCurrentDirectory() |> Directory.GetCreationTime

let checkCreation (time : DateTime) =
    if (time - DateTime.Now).TotalDays < 7.0 then "New"
    else "Old"

let time =
    let directory = Directory.GetCurrentDirectory()
    Directory.GetCreationTime directory

Directory.GetCurrentDirectory()
|> Directory.GetCreationTime
|> checkCreation

type Employee =
    { Age : int }

let where filter employees =
    seq { 
        for employee in employees do
            if filter employee then yield employee
    }

let employees =
    [ { Age = 21 }
      { Age = 35 }
      { Age = 36 } ]

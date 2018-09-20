type FootballResult =
  { HomeTeam : string
    AwayTeam : string
    HomeGoals : int
    AwayGoals : int }

let create (ht, hg) (at, ag) : FootballResult =
  { HomeTeam = ht
    AwayTeam = at
    HomeGoals = hg
    AwayGoals = ag }

let results =
  [ create ("Brazil", 1) ("Germany", 2)
    create ("Argentina", 1) ("Germany", 2)
    create ("Brazil", 1) ("Argentina", 1)
    create ("Argentina", 1) ("Brazil", 2) ]

let isAwayWin result = result.AwayGoals > result.HomeGoals

results
|> List.filter isAwayWin
|> List.countBy (fun result -> result.AwayTeam)
|> List.sortByDescending (fun (_, awayWins) -> awayWins)

let numbers = [ 1..100 ]
let multiplyByTwo n = n * 2

numbers
|> List.map multiplyByTwo
|> List.filter (fun n -> n % 2 = 0)
|> List.iter (fun n -> System.Console.Write(string (n) + ","))
numbers |> List.pairwise
numbers |> List.windowed 10

type name =
  { Name : string
    Town : string }

let names =
  [ { Name = "Sambaran"
      Town = "Bangalore" }
    { Name = "Babai"
      Town = "Bangalore" }
    { Name = "Jhunai"
      Town = "Bangalore" }
    { Name = "Shankha"
      Town = "Kolkata" } ]

names |> List.partition (fun n -> n.Town = "Bangalore")

open System.Collections.Generic

let inventory = Dictionary<string, float>()

inventory.Add("Apple", 1.23)
inventory.Add("Pear", 0.3)
inventory.Add("Mango", 5.32)
inventory.Add("Banana", 3.12)

let immutableInventory : IDictionary<string, float> =
  [ "Apple", 1.23
    "Pear", 0.3
    "Mango", 5.32
    "Banana", 3.12 ]
  |> dict

let mappedInventory =
  [ "Apple", 1.23
    "Pear", 0.3
    "Mango", 5.32
    "Banana", 3.12 ]
  |> Map.ofList

let newMappedInventory = mappedInventory.Add("Guava",3.2)
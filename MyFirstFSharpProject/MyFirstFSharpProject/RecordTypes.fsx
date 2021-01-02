
type Address = { Street : string; Town : string; City: string }

type Customer =
    { Forename : string
      Surname : string
      Age : int
      Address : Address
      EmailAddress : string }

let customer =
    { Forename = "Joe"
      Surname = "Bloggs"
      Age = 30
      Address =
        { Street = "The street"
          Town = "The town"
          City = "The city" }
      EmailAddress = "joe@bloggs.com"
    }

let customerneu =
    { Forename = "Joe"
      Surname = "Bloggs"
      Age = 30
      Address =
        { Street = "The street"
          Town = "The town"
          City = "The city" }
      EmailAddress = "joe@bloggs.com"
    }

customer.Address.City

//type Car =
//    { Manufacturer : string
//      EngineSize : int
//      NumberOfDoors : int
//      Color : string
//      Price : double}
      
//let testCar =
//    { Manufacturer = "test"
//      EngineSize = 5
//      NumberOfDoors = 3
//      Color = "Red"
//      Price = 10000.5 }

let updatedCustomer =
    { customer with
        Age = 5}

let isSameCustomer = customer.Address = customerneu.Address
let check = customer.Address.Equals(customerneu.Address)
let check2 = System.Object.ReferenceEquals(customer.Address, customerneu.Address)

let testFunction customer =
    let newAge = 
        let r = System.Random()
        r.Next(18, 46)
    printfn "Changed customer's age from %d to %d" customer.Age newAge
    { customer with Age = newAge }
    

let updateAge customer =
    let newAge =
        let r = System.Random()
        r.Next(18, 46)
    printfn "Changed customer's age from %d to %d" customer.Age newAge
    { customer with Age = newAge }

testFunction(customerneu)

type Home = 
    { Street : string
      Town : string
      City : string }

do
    let myHome = { Street = "The Street"; Town = "The Town"; City = "The City" }
    let myHome = { myHome with City = "The Other City" }
    let myHome = { myHome with City = "The Third City" }
    ()




/// Car example from Lesson 6 with Record Types

type Distance =
   | Far = 0
   | Medium = 1
   | Short = 2

let drive (petrol, distance) =
    if distance = Distance.Far then petrol / 2.0
    elif distance = Distance.Medium then petrol - 10.0
    else petrol - 1.0

let petrol = 100.0
let firstState = drive(petrol, Distance.Far)
let secondState = drive(firstState, Distance.Medium)
let finalState = drive(secondState, Distance.Short)
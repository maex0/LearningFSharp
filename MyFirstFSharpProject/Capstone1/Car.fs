module Car

open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Office" then 50
    elif destination = "Stadium" then 25
    else failwith "Unknown destination!"

/// Calculates the remaining petrol after driving
let calculateRemainingPetrol(currentPetrol, distance) =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol"


/// Drives to a given destination given a starting amount of petrol
let driveTo (petrol, destination) = 
    let distance = getDistance(destination)
    let remainingPetrol = calculateRemainingPetrol(petrol, distance)
    if destination = "Gas" then remainingPetrol + 50
    else remainingPetrol

type Car =
    { Manufacturer : string
      EngineSize : int
      NumberOfDoors : int
      Color : string
      Price : double}
      
let testCar =
    { Manufacturer = "test"
      EngineSize = 5
      NumberOfDoors = 3
      Color = "Red"
      Price = 10000.5 }
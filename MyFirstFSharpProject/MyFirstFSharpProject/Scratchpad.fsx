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




// Couple of quick tests
getDistance("Home") = 25
getDistance("Stadium") = 25
calculateRemainingPetrol(100, 25) = 75
calculateRemainingPetrol(100, 75) = 25
calculateRemainingPetrol(100, 100) = 0
calculateRemainingPetrol(10, 15) //should return exception

let distanceToGas = getDistance("Gas")
calculateRemainingPetrol(25, distanceToGas)
calculateRemainingPetrol(5, distanceToGas)

let a = driveTo(100, "Office")
let b = driveTo(a, "Stadium")
let c = driveTo(b, "Gas")
let answer = driveTo(c, "Home")
answer = 40

open System
open System.IO

type Customer = 
    {
        Age: int
    }

let printCustomerAge writer customer =
    if customer.Age < 13 then writer "Child!"
    elif customer.Age < 20 then writer "Teenager!"
    else writer "Adult!"

let cust1 = {Age=12}
let cust2 = {Age=16}
let cust3 = {Age=43}


let printToConsole = printCustomerAge Console.WriteLine
printToConsole cust1
printToConsole cust2
printToConsole cust3


let writeToFile text = File.WriteAllText(@"C:\temp\output.txt", text)

let printToFile = printCustomerAge writeToFile
printToFile cust3

let readFromFile = File.ReadAllText(@"C:\temp\output.txt")
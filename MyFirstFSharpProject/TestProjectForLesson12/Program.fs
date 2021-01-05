// Learn more about F# at http://fsharp.org

open System
open Domain
open Operations

[<EntryPoint>]
let main argv =
    let customer = { Firstname="John"; Lastname="Doe"; Age=19 }
    if customer |> isOlderThan 18 then printf "%s is an adult!" customer.Firstname
    else printf "%s is a child." customer.Firstname
    0

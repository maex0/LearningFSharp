module Operations
open Domain

let getInitals customer = customer.Firstname.[0], customer.Lastname.[0]
let isOlderThan age customer = customer.Age > age
    
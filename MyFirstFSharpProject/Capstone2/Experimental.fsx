open System

type Customer = 
    { Firstname : string
      Lastname : string }

type Account =
    { AccountId : Guid
      Balance : decimal
      Owner : Customer}
     
let acc = { AccountId=Guid.Empty; Balance=13.12M; Owner= { Firstname="John"; Lastname="Doe" } }

/// Deposites an amount into an account
let deposit (amount:decimal) (account:Account) : Account =
    {AccountId = Guid.Empty; Owner={Firstname="Sam"; Lastname="Test"}; Balance=10M}
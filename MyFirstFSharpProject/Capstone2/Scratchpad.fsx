open System

type Customer =
    { FirstName: string
      LastName: string
      Age: int }

type Account =
    { AccountId: Guid
      Balance: decimal
      Owner: Customer }

let account =
    { AccountId = Guid.Empty
      Balance = 10M
      Owner =
          { FirstName = "Max"
            LastName = "Mustermann"
            Age = 20 } }

/// Deposits an amount into an account
let deposit (amount: decimal) (account: Account) : Account =
    { account with
          Balance = account.Balance + amount }

///example account |> deposit 50 |> withdraw 25 |> deposit 10
let withdraw (amount: decimal) (account: Account) : Account =
    if amount > account.Balance then
        account
    else
        { account with
              Balance = account.Balance - amount }


///let fileSystemAudit account message =
    
    
///let console account message =
    
let parseName (name:string) =
    let parts = name.Split(' ')
    let forename = parts.[0]
    let surname = parts.[1]
    forename, surname

let name = parseName("Isaac Abraham")
let forename, lastname = name
let fname, sname = parseName("Isaac Abraham")

let ab = 4, 3, "Maxi"

let parse (person:string) = 
    let parts = person.Split(' ')
    let playername = parts.[0]
    let game = parts.[1]
    let score = int(parts.[2])
    playername, game, score

let a, b, c = parse("Mary Asteroids 2500")
let test = parse("Mary Asteroids 2500")
let y = 3,2
let x = fst(y)
let z = snd(y)


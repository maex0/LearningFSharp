open System
open System.IO

let buildDt year month day = DateTime(year, month, day)
let buildDtThisYear = buildDt DateTime.UtcNow.Year
let buildDtThisMonth = buildDtThisYear DateTime.UtcNow.Month

//let buildDt year month day = DateTime(year, month, day)
//let buildDtThisYear month day = buildDt DateTime.UtcNow.Year month day
//let buildDtThisMonth day = buildDtThisYear DateTime.UtcNow.Month day

buildDtThisMonth 30

let writeToFile (date:DateTime) filename text = 
    let path = sprintf "%s-%s.txt" (date.ToString "yyMMdd") filename
    printf "%s" path
    System.IO.File.WriteAllText(path, text)

let writeToFileToday = writeToFile DateTime.Now
let writeToFileTodayFilename = writeToFileToday "Testfile"

writeToFile DateTime.Now "test" "text"

writeToFileTodayFilename "testtext"

let checkCreation (creationDate:DateTime) =
    if (DateTime.UtcNow - creationDate).TotalDays > 7. then sprintf "Old"
    else sprintf "New"

Directory.GetCurrentDirectory()
    |> Directory.GetCreationTime
    |> checkCreation


let add a b = a + b
let timesBy a b = a * b

let answer = 10 |> add 5 |> timesBy 2 |> add 20 |> add 7 |> timesBy 3
let test = 3 |> add 4


let drive distance petrol =
    if distance = "far" then petrol / 2.0
    elif distance = "medium" then petrol - 10.0
    else petrol - 1.0
    
let startPetrol = 100.0
startPetrol
|> drive "far"
|> drive "medium"
|> drive "short"

let checkCurrentDirectoryAge =
    Directory.GetCurrentDirectory
    >> Directory.GetCreationTime
    >> checkCreation

let description = checkCurrentDirectoryAge()
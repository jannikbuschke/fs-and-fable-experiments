open System

[ 1..10 ]
|> List.fold (fun current next -> current + next) 0

let rec sum list =
    match list with
    | [] -> 0
    | x :: xs -> x + sum xs

sum [ 1..10 ]

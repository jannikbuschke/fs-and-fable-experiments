#r "nuget: FsToolkit.ErrorHandling"
#r "nuget: FsToolkit.ErrorHandling.TaskResult"

open FsToolkit.ErrorHandling

// # Function compositio

// https://fsharpforfunandprofit.com/posts/function-composition/

// What does this mean?
let f0 (x: int -> int) (y: int) = x y

// let F x y z = x (y z)? or let F x y z = (x y) z?
// F is a function taking with three parameters. x and y are functions. Is y applied to z first, or x applied to y first?
// Answer: x is applied to y first:
// Let F x y z = (x y) z

let doubleAndAdd x y = x * x + y
let f3 x = x * x

let f (x: int -> int -> int) (y: int) (z: int) = x y z


let result = f doubleAndAdd 5 1

result

let compose f g x = g (f (x))

let compose2 f g = f >> g

let doubleAsync (i) = task{return i+1}
let double x = x*x

let toResult o =
    match o with | Some o -> Ok o | None -> Error("None")

let composed =
    doubleAsync >> Task.map double >> Task.map Some >> Task.map toResult

taskResult {
    let input = 5
    let! result = composed 5

    return result
}

taskResult{
    let o1 = Some 5
    let o2 = None

    let tuple = ("Hello",5)
    let first = fst tuple
    let scnd = snd tuple

    // what is boxing/unboxing

    let result = Option.map2 (fun o1 o2->"Hello") o1 o2

    return result
}

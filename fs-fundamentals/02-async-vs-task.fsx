#r "nuget: FsToolkit.ErrorHandling"
#r "nuget: FsToolkit.ErrorHandling.TaskResult"

open System
open FsToolkit.ErrorHandling

// found the Task module functions like bind, and map in https://github.com/demystifyfp/FsToolkit.ErrorHandling/blob/master/src/FsToolkit.ErrorHandling.TaskResult/Task.fs
// /// Creates a `Task` that attempts to execute the provided task,
/// returning `Choice1Of2` with the result if the task completes
/// without exceptions, or `Choice2Of2` with the exception if an
/// exception is thrown.
//    let catch (x: Task<_>) =

async {
    System.Console.WriteLine("Hello")
    return "Hello"
}
|> Async.StartAsTask

// implicit conversion async => task seems to work
task {
    System.Console.WriteLine("1")

    let! foo =
        async {
            System.Console.WriteLine("2")
            return "Hello"
        }

    System.Console.WriteLine("3")

    return foo
}

// other way around does not seem to work
async {
    System.Console.WriteLine("1")

    let! foo =
        task {
            System.Console.WriteLine("2")
            return "Hello"
        }
        // this seems to be necessary
        |> Async.AwaitTask

    System.Console.WriteLine("3")

    return foo
}

let listOfAsyncs =
    [ async {
          do! Async.Sleep(50)
          System.Console.WriteLine("1")
          return ()
      }
      async {
          System.Console.WriteLine("2")
          return ()
      } ]

listOfAsyncs |> Async.Parallel |> Async.StartAsTask
listOfAsyncs |> Async.Sequential |> Async.StartAsTask

// Async.map Async.bind
// Task.map Task.bind
// bindOption, mapOption
// taskResult

let x =
    taskResult {
        let! x = task { return 5 }
        do! true |> Result.requireTrue("Error")
        return 10
    }

x.Result

let normalFunc (x:int) =
    x * 2

let funcWithOptionalInput (x: 'a option)=
    5

let taskFunc x = task { return x }


// piping
task {
    // if I want to two consecutive task invocations, without let binding Task.bind could be used
    // use Task.map
    let! result = (taskFunc 5) |> Task.map normalFunc

    // instead of
    let! result1 = taskFunc 5
    let result2 = normalFunc result1
    return ()
}

task {
    // if I want to two consecutive task invocations, without let binding Task.bind could be used
    // use Task.bind
    let! result = (taskFunc 5) |> Task.bind taskFunc
    // instead of
    let! result1 = taskFunc 5
    let! result2 = taskFunc result1
    return ()
}

// Linq.Select = map
// Ling.SelectMany = bind
// await = bind
// Nullable.? = bind
// let! = bind

// selectMany = bind (function)
// flatten?
taskResult {
    // if I want to two consecutive task invocations, without let binding Task.bind could be used
    // use Task.bind
    let result =
        5
        |> taskFunc
        |> TaskResult.bind TaskResult.Ok

    // instead of
    let! result1 = taskFunc 5
    let! result2 = result1 |> Some |> funcWithOptionalInput
    return result
}


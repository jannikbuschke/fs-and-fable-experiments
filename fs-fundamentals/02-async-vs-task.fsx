open System


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

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Hosting
open Fable.Remoting.Server
open Fable.Remoting.AspNetCore
open Polly
open Polly.Caching
open Polly.Caching.MemoryCache
open Polly.Registry
open Shared
open Microsoft.AspNetCore.Cors.Infrastructure
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection

module MyService =
    let rnd = Random()

type MyService() =
    member this.GetRandomNumber() = MyService.rnd.Next()

[<EntryPoint>]
let main args =

    let musicStore: IMusicStore =
        { popularAlbums =
            fun () ->
                async {
                    return
                        [ { id = 2
                            title = "The Dark Side of the Moon"
                            genre = "Rock"
                            released = DateTime.Parse("1982/01/01") } ]
                }

        }


    // Create API from musicStore value
    let webApp =
        Remoting.createApi ()
        |> Remoting.fromValue musicStore

    // let configureApp (app: IApplicationBuilder) =
    //     // Add the API to the ASP.NET Core pipeline
    //     app.UseRemoting(webApp)

    let builder = WebApplication.CreateBuilder(args)

    builder.Services.AddControllers() |> ignore
    builder.Services.AddCors() |> ignore

    builder.Services.AddSingleton<MyService>()
    |> ignore

    builder.Services.AddMemoryCache() |> ignore

    builder.Services.AddSingleton<Polly.Caching.IAsyncCacheProvider, Polly.Caching.Memory.MemoryCacheProvider>()
    |> ignore

    builder.Services.AddSingleton<Polly.Registry.IReadOnlyPolicyRegistry<string>, Polly.Registry.PolicyRegistry>
        (fun serviceProvider ->
            let registry = PolicyRegistry()

            registry.Add(
                "myCachePolicy",
                Policy.CacheAsync(
                    serviceProvider
                        .GetRequiredService<IAsyncCacheProvider>()
                        .AsyncFor<int>(),
                    TimeSpan.FromMinutes(5)
                )
            )

            registry)
    |> ignore

    let app = builder.Build()

    app.UseCors (fun x ->
        x
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
        |> ignore)
    |> ignore

    app.UseRemoting webApp


    app.MapGet(
        "/polly/{key}",
        Func<HttpContext, Task<{| Value: int; Duration: float |}>> (fun (ctx) ->
            task {
                let key = ctx.Request.RouteValues["key"] :?> string

                let myService = ctx.RequestServices.GetRequiredService<MyService>()

                let policy =
                    ctx
                        .RequestServices
                        .GetRequiredService<IReadOnlyPolicyRegistry<string>>()
                        .Get<IAsyncPolicy<int>>("myCachePolicy")

                let stopWatch = System.Diagnostics.Stopwatch.StartNew()

                let! result =
                    policy.ExecuteAndCaptureAsync(
                        (fun (context) ->
                            task {
                                printf "waiting 2 seconds"
                                do! System.Threading.Tasks.Task.Delay(2000)
                                return myService.GetRandomNumber()
                            }),
                        Context(key)
                    )

                let duration = stopWatch.Elapsed.TotalMilliseconds
                stopWatch.Stop()

                return
                    {| Value = result.Result
                       Duration = duration |}
            })
    )
    |> ignore

    app.MapGet("/", Func<string>(fun () -> "Hello World!"))
    |> ignore

    app.Run()

    0 // Exit code

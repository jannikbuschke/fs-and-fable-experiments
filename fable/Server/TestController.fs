namespace Gertrud.Core.Features.Poly.TestPolly

open Microsoft.AspNetCore.Mvc
open Polly
open Polly.Registry

[<Route("api/test-polly")>]
[<ApiController>]
type TestController(policyRegistry: IReadOnlyPolicyRegistry<string>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        task {
            let _cachePolicy = policyRegistry.Get<IAsyncPolicy<int>>("myCachePolicy")

            let! result =
                _cachePolicy.ExecuteAsync (fun () ->
                    task {
                        printf "waiting 5 seconds"
                        do! System.Threading.Tasks.Task.Delay(5000)
                        return 1
                    })

            return Ok(result)
        }

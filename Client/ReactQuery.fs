namespace App

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Router

type QueryKey = string array
type QueryFn<'T> = QueryKey -> Async<'T>

type UseQueryResult<'T> = { Data: 'T }
type UseQuery<'T> = QueryKey -> QueryFn<'T>

type QueryClient = unit -> obj

module ReactQuery =
    open Fable.Core.JS
    // The member name is taken from decorated value, here `myFunction`
    [<ImportMember("react-query")>]
    let useQuery (queryKey: string array, queryFn: string array -> Promise<int>) : obj = jsNative

    // let useQueryImport: obj = importMember "react-query"

    // let useQuery<'T> array fn =
    //     // let queryKey = array |> Array.map (fun x -> x :> obj) |> Array.toObj
    //     // let queryFn = fn :> obj
    //     Fable.Core.JsInterop.
    //     Fable.Core.JS.


    let QueryClientProvider: obj = import "QueryClientProvider" "react-query"
    let QueryClient: JsConstructor = import "QueryClient" "react-query"
    let queryClient = QueryClient.Create()

    let createQueryClientProvider (children) =
        Interop.reactApi.createElement (
            QueryClientProvider,
            Fable.Core.JsInterop.createObj [ "client" ==> queryClient
                                             "children" ==> children ]
        )

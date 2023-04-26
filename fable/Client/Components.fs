namespace App

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Router
open Fable.Remoting.Client
open Feliz.Styles
open MantineCore
open Shared
open Fable.Core.JsInterop
// open Input
open Fable.Import.Browser
// open Fable.Promise

module Mantine =
    // do a named import for TextInput from @mantine/core in fable
    let textInput: obj = import "TextInput" "@mantine/core"

    module TextInput =
        let create props =
            Interop.reactApi.createElement (textInput, Fable.Core.JsInterop.createObj props)

    let x y = async { return y }

    let double (value: int) =
        promise {
            let! foo = async { return 5 } |> Async.StartAsPromise
            return foo * 5
        }


module App =
    // musicStore : IMusicStore
    let musicStore: IMusicStore =
        Remoting.createApi ()
        // |> Remoting.withBaseUrl "https://localhost:7128"
        |> Remoting.buildProxy<IMusicStore>

    async {
        printfn "Fetching albums..."
        let! albums = musicStore.popularAlbums ()
        printfn "Albums %d" albums.Length

        for album in albums do
            printfn "%s (%s)" album.title album.genre
    }
    |> Async.StartImmediate

module Interop =
    // import { useQuery } from "react-query"
    [<Import("useQuery", "react-query")>]
    let mylib: unit -> string = jsNative

    [<Emit("Object.assign({}, $0, $1)")>]
    let objectAssign (x: obj) (y: obj) = jsNative

type Components =

    [<ReactComponent>]
    static member Hello() =
        // Browser.Dom.console.log (ReactQuery.useQuery)
        // Browser.Dom.console.log (ReactQuery.QueryClient)
        let x = ReactQuery.useQuery ([| "asd" |], (fun (key) -> Mantine.double (5)))

        Browser.Dom.console.log (x)
        // Browser.Dom.console.log (xy)
        // Fable.Core.JS.Console.log(x)

        Html.h1 ("hello " + x?data)
    // /// <summary>
    // /// A stateful React component that maintains a counter
    // /// </summary>
    [<ReactComponent>]
    static member Counter() =
        // let x = Interop.mylib ()
        // let (count, setCount) = React.useState (0)

        // let x: string = count?toString ()?lenght

        ReactQuery.createQueryClientProvider [ AppShell.create [ AppShell.Header(Html.div "Header")
                                                                 AppShell.Aside(Html.div "Aside")
                                                                 AppShell.Footer(Html.div "Footer") ] [
                                                   Html.div [ Components.Hello()
                                                              TextInput.create [ TextInput.Placeholder "hello world"
                                                                                 TextInput.Label(Html.h1 "Label!") ]
                                                              TextInput.create [ TextInput.Disabled true ] ]
                                               ] ]

    /// <summary>
    /// A React component that uses Feliz.Router
    /// to determine what to show based on the current URL
    /// </summary>
    [<ReactComponent>]
    static member Router() =
        let (currentUrl, updateUrl) = React.useState (Router.currentUrl ())

        React.router [ router.onUrlChanged updateUrl
                       router.children [ match currentUrl with
                                         | [] -> Html.h1 "Index"
                                         | [ "counter" ] -> Components.Counter()
                                         | otherwise -> Html.h1 "Not found" ] ]

module MantineCore

// open Fable.Core
// open Fable.Core.JsInterop
// open Fable.React
open System.Collections.Generic
open Feliz
open Fable.Core.JsInterop

type ColorScheme =
    | Light
    | Dark

type DefaultMantineColor =
    | Dark
    | Gray
    | Red
    | Pink
    | Grape
    | Violet
    | Indigo
    | Blue
    | Cyan
    | Green
    | Lime
    | Yellow
    | Orange
    | Teal
    | String of string

//MantineThemeColors = Color + 0...9


// export type MantineSize = 'xs' | 'sm' | 'md' | 'lg' | 'xl' | (string & {});
// export type MantineNumberSize = MantineSize | number | (string & {});
// export type MantineSizes = Record<MantineSize, string>;

type MantineSize =
    | XS
    | SM
    | MD
    | LG
    | XL
    | String of string

type Record<'TKey, 'TValue> = Dictionary<'TKey, 'TValue>

type MantineNumberSize =
    | MantineSize
    | Number of int
    | Strting of string

type MantineSizes = Record<MantineSize, string>

//
// export type SystemProp<Value> = Value | Partial<Record<MantineSize | (string & {}), Value>>;
//
// export type SpacingValue = MantineNumberSize | (string & {});

// https://github.com/mantinedev/mantine/blob/master/src/mantine-styles/src/theme/types/MantineStyleSystem.ts
// type SystemProp<'T> = Value of 'T | Partial<Record<MantineSize, 'T>>

type SpacingValue =
    | MantineNumberSize of MantineNumberSize
    | String of string



type Width =
    | StringWidth of string
    | NumberWidth of int

type Height =
    | StringHeight of string
    | NumberHeight of int

type VerticalSectionHeight = Height
type VerticalSectionPosition = obj

type Radius =
    | Int of int
    | XS
    | SM
    | MD
    | LG
    | XL

type NumberSize =
    | Int of int
    | XS
    | SM
    | MD
    | LG
    | XL

type Size =
    | XS
    | SM
    | MD
    | LG
    | XL

[<AutoOpen>]
type Input =
    static member inline Description(v: Fable.React.ReactElement) = "Description" ==> v
    static member inline DescriptionProps(v: Record<string, obj>) = "DescriptionProps" ==> v
    static member inline Disabled(v: bool) = "disabled" ==> v
    static member inline Error(v: Fable.React.ReactElement) = "error" ==> v

let textInput: obj = import "TextInput" "@mantine/core"

[<AutoOpen>]
type TextInput =
    static member inline Description(v: Fable.React.ReactElement) = "description" ==> v
    static member inline DescriptionProps(v: Record<string, obj>) = "descriptionProps" ==> v
    static member inline Disabled(v: bool) = "disabled" ==> v
    static member inline Placeholder(v:string)="placeholder"==>v
    static member inline Error(v: Fable.React.ReactElement) = "error" ==> v
    static member inline ErrorProps(v: Record<string, obj>) = "errorProps" ==> v
    static member inline Icon(v: Fable.React.ReactElement) = "icon" ==> v
    static member inline IconWidth(v: Width) = "iconWidth" ==> v

    static member inline InputContainer(v: Fable.React.ReactElement -> Fable.React.ReactElement) =
        "inputContainer" ==> v

    static member inline InputWrapperOrder(v: string array) = "inputWrapperOrder" ==> v
    static member inline Label(v: Fable.React.ReactElement) = "label" ==> v
    static member inline LabelProps(v: Record<string, obj>) = "labelProps" ==> v
    static member inline Radius(v: Radius) = "radius" ==> v
    static member inline Required(v: bool) = "required" ==> v
    static member inline RightSection(v: Fable.React.ReactElement) = "rightSection" ==> v
    static member inline RightSectionProps(v: Record<string, obj>) = "rightSectionProps" ==> v
    

    static member inline RightSectionWidth(v: Width) = "rightSectionWidth" ==> v
    static member inline Size(v: Size) = "size" ==> v
    // HTMLInputTypeAttribute
    static member inline Type(v: obj) = "type" ==> v
    static member inline Variant(v: obj) = "variant" ==> v
    static member inline WithAsterisk(v: bool) = "withAsterisk" ==> v

    static member inline WrapperProps(v: Record<string, obj>) = "wrapperProps" ==> v

    static member inline create props =

        Interop.reactApi.createElement (textInput, createObj !!props)

type Color =
    | Green
    | Red

type ChipType =
    | Checkbox
    | Radio

[<AutoOpen>]
type Chip =
    static member inline Checked(v: bool) = "checked" ==> v
    static member inline Children(v: Fable.React.ReactElement) = "children" ==> v
    static member inline Color(v: Color) = "color" ==> v
    static member inline DefaultChecked(v: bool) = "defaultChecked" ==> v
    static member inline Id(v: string) = "id" ==> v
    static member inline OnChange(v: bool -> unit) = "onChange" ==> v
    static member inline Radius(v: Radius) = "radius" ==> v
    static member inline Size(v: NumberSize) = "size" ==> v

    static member inline Type(v: ChipType) =
        "type"
        ==> match v with
            | Checkbox -> "checkbox"
            | Radio -> "radio"

    static member inline Variant(v: obj) = "variant" ==> v
    static member inline WrapperProps(v: Record<string, obj>) = "wrapperProps" ==> v

    static member inline create props =
        Interop.reactApi.createElement (textInput, createObj !!props)

// type Prop =
//     | Value of int
//     | MinValue of int
//     | MaxValue of int
//     | StartColor of string
//
//
// let reactSpeedometer (props: Prop list) : ReactElement =
//     let propsObject = keyValueList CaseRules.LowerFirst props // converts Props to JS object
//     ofImport "default" "react-d3-speedometer" propsObject [] // import the default function/object from react-d3-speedometer
//
// Feliz.Interop.reactApi.createElement (
//     importDefault "react-d3-speedometer",
//     createObj [ "minValue" ==> 0
//                 "maxValue" ==> 100
//                 "value" ==> 10 ]
// )


// import { AppShell, Navbar, Header } from '@mantine/core'
let appShell: obj = import "AppShell" "@mantine/core"
let navbar: obj = import "Navbar" "@mantine/core"
let Header: obj = import "Header" "@mantine/core"

type Layout =
    | Default
    | Alt

[<AutoOpen>]
type AppShell =
    static member inline Aside(v: Fable.React.ReactElement) = "aside" ==> v
    static member inline AsideOffsetBreakpoint(v: NumberSize) = "asideOffsetBreakpoint" ==> v
    static member inline Children(v: Fable.React.ReactElement) = "children" ==> v
    static member inline Fixed(v: bool) = "fixed" ==> v
    static member inline Footer(v: Fable.React.ReactElement) = "footer" ==> v
    static member inline Header(v: Fable.React.ReactElement) = "header" ==> v
    static member inline Hidden(v: bool) = "hidden" ==> v

    static member inline Layout(v: Layout) =
        "layout"
        ==> match v with
            | Default -> "default"
            | Alt -> "alt"

    static member inline Navbar(v: Fable.React.ReactElement) = "navbar" ==> v
    static member inline NavbarOffsetBreakpoint(v: NumberSize) = "navbarOffsetBreakpoint" ==> v
    static member inline Padding(v: NumberSize) = "padding" ==> v
    static member inline ZIndex(v: int) = "zIndex" ==> v

    static member inline create props children =

        Interop.reactApi.createElement (appShell, createObj !!props, children)

[<AutoOpen>]
type Navbar =
    static member inline Children(v: Fable.React.ReactElement) = "children" ==> v
    static member inline Fixed(v: bool) = "fixed" ==> v
    static member inline Height(v: VerticalSectionHeight) = "height" ==> v
    static member inline Hidden(v: bool) = "hidden" ==> v
    static member inline HiddenBreakpoint(v: NumberSize) = "hiddenBreakpoint" ==> v
    static member inline Position(v: VerticalSectionPosition) = "position" ==> v
    static member inline WithBorder(v: bool) = "withBorder" ==> v
    static member inline ZIndex(v: int) = "zIndex" ==> v

[<AutoOpen>]
type Footer =
    static member inline Children(v: Fable.React.ReactElement) = "children" ==> v
    static member inline Fixed(v: bool) = "fixed" ==> v
    static member inline Height(v: VerticalSectionHeight) = "height" ==> v
    static member inline Hidden(v: bool) = "hidden" ==> v
    static member inline Position(v: VerticalSectionPosition) = "position" ==> v
    static member inline WithBorder(v: bool) = "withBorder" ==> v
    static member inline ZIndex(v: int) = "zIndex" ==> v

[<AutoOpen>]
type AspectRatio =
    static member inline Ratio(v: float) = "ratio" ==> v

[<AutoOpen>]
type Center =
    static member inline Children(v: Fable.React.ReactElement) = "children" ==> v
    static member inline Inline(v: bool) = "inline" ==> v


[<AutoOpen>]
type Container =
    static member inline Fluid(v: bool) = "fluid" ==> v
    static member inline Size(v: NumberSize) = "size" ==> v
    static member inline Sizes(v: NumberSize list) = "sizes" ==> v

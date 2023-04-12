// ts2fable 0.7.1
module rec Styles
open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type TemplateStringsArray = System.Collections.Generic.IReadOnlyList<string>
type Record<'K,'V> = Dictionary<'K,'V>
type CSSObject = obj

module __theme_types =
    type ColorScheme = obj
    type MantineThemeBase = obj

module JSX=
    type Element = obj

module React =
     type  CSSProperties = obj
     type ReactNode = obj

// open React

module __theme_ColorSchemeProvider =
    type ColorScheme = __theme_types.ColorScheme

    type [<AllowNullLiteral>] IExports =
        abstract useMantineColorScheme: unit -> ColorSchemeContextProps
        abstract ColorSchemeProvider: p0: ColorSchemeProviderProps -> JSX.Element

    type [<AllowNullLiteral>] ColorSchemeContextProps =
        abstract colorScheme: ColorScheme with get, set
        abstract toggleColorScheme: ?colorScheme: ColorScheme -> unit

    type [<AllowNullLiteral>] ColorSchemeProviderProps =
        inherit ColorSchemeContextProps
        abstract children: React.ReactNode with get, set

    module ColorSchemeProvider =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

module __theme_default_colors =

    type [<AllowNullLiteral>] IExports =
        abstract DEFAULT_COLORS: Record<string, string * string * string * string * string * string * string * string * string * string>

module __theme_default_theme =
    type MantineThemeBase = __theme_types.MantineThemeBase

    type [<AllowNullLiteral>] IExports =
        abstract MANTINE_COLORS: ResizeArray<string>
        abstract MANTINE_SIZES: string * string * string * string * string
        abstract _DEFAULT_THEME: MantineThemeBase
        abstract DEFAULT_THEME: obj

module __theme_GlobalStyles =

    type [<AllowNullLiteral>] IExports =
        abstract GlobalStyles: p0: GlobalStylesP0 -> JSX.Element

    type [<AllowNullLiteral>] GlobalStylesP0 =
        abstract theme: MantineTheme with get, set

module __theme_MantineCssVariables =

    type [<AllowNullLiteral>] IExports =
        abstract MantineCssVariables: p0: MantineCssVariablesP0 -> JSX.Element

    type [<AllowNullLiteral>] MantineCssVariablesP0 =
        abstract theme: MantineTheme with get, set

module __theme_MantineProvider =

    type [<AllowNullLiteral>] IExports =
        abstract useMantineTheme: unit -> MantineTheme
        abstract useMantineProviderStyles: ``component``: U2<string, ResizeArray<string>> -> ResizeArray<IExportsUseMantineProviderStyles>
        abstract useMantineEmotionCache: unit -> EmotionCache
        abstract useComponentDefaultProps: ``component``: string * defaultProps: 'U * props: 'T -> obj
        abstract MantineProvider: p0: MantineProviderProps -> JSX.Element

    type [<AllowNullLiteral>] MantineProviderProps =
        abstract theme: MantineThemeOverride option with get, set
        abstract emotionCache: EmotionCache option with get, set
        abstract withNormalizeCSS: bool option with get, set
        abstract withGlobalStyles: bool option with get, set
        abstract withCSSVariables: bool option with get, set
        abstract children: React.ReactNode with get, set
        abstract ``inherit``: bool option with get, set

    module MantineProvider =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

    type [<AllowNullLiteral>] IExportsUseMantineProviderStyles =
        abstract styles: U2<Record<string, obj>, (MantineTheme -> obj option -> Record<string, obj>)> with get, set
        abstract classNames: Record<string, string> with get, set

module __theme_NormalizeCSS =

    type [<AllowNullLiteral>] IExports =
        abstract NormalizeCSS: unit -> JSX.Element

module __tss_create_styles =

    type [<AllowNullLiteral>] IExports =
        abstract createStyles: input: U2<(MantineTheme -> 'Params -> (string -> string) -> 'Input), 'Input> -> ('Params -> UseStylesOptions<'Key> -> IExportsCreateStyles)

    type [<AllowNullLiteral>] UseStylesOptions<'Key> =
        abstract classNames: obj option with get, set
        abstract styles: U2<obj, (MantineTheme -> obj option -> obj)> option with get, set
        abstract name: U2<string, ResizeArray<string>> with get, set
        abstract unstyled: bool option with get, set

    type [<AllowNullLiteral>] IExportsCreateStyles =
        abstract classes: obj with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __tss_default_emotion_cache =

    type [<AllowNullLiteral>] IExports =
        abstract defaultMantineEmotionCache: obj

module __tss_Global =
    // type CSSObject = __tss_@emotion_react.CSSObject

    type [<AllowNullLiteral>] IExports =
        abstract Global: p0: GlobalStylesProps -> JSX.Element

    type EmotionStyles =
        U2<CSSObject, ResizeArray<CSSObject>>

    type [<AllowNullLiteral>] GlobalStylesProps =
        abstract styles: U2<EmotionStyles, (MantineTheme -> EmotionStyles)> with get, set

module __tss_index =
    type EmotionCache = obj//__tss_@emotion_cache.EmotionCache


module __tss_use_css =
    open __tss_index
    type CSS = obj

    type [<AllowNullLiteral>] IExports =
        abstract cssFactory: (IExportsCssFactory -> IExportsCssFactory2)
        abstract useCss: unit -> UseCssReturn

    type [<AllowNullLiteral>] UseCssReturn =
        abstract css: CSS with get, set
        abstract cx: (obj option -> string) with get, set

    type [<AllowNullLiteral>] IExportsCssFactory =
        abstract cache: EmotionCache with get, set

    type [<AllowNullLiteral>] IExportsCssFactory2 =
        abstract css: CSS with get, set
        abstract cx: (obj option -> string) with get, set

// open __tss_index

module __tss_use_emotion_cache =

    type [<AllowNullLiteral>] IExports =
        abstract useEmotionCache: unit -> obj

module __theme_functions_attach_functions =

    type [<AllowNullLiteral>] IExports =
        abstract attachFunctions: themeBase: MantineThemeBase -> MantineTheme

module __theme_types_ColorScheme =

    type [<StringEnum>] [<RequireQualifiedAccess>] ColorScheme =
        | Light
        | Dark

module __theme_types_DeepPartial =

    type [<AllowNullLiteral>] DeepPartial<'T> =
        interface end

module __theme_types_DefaultProps =

    type Sx =
        U2<CSSObject, (MantineTheme -> CSSObject)>

    type ClassNames<'StylesNames> =
        obj

    type Styles<'StylesParams> =
        Styles<obj, 'StylesParams>

    type Styles<'StylesNames, 'StylesParams> =
        U2<obj, (MantineTheme -> 'StylesParams -> obj)>

    type DefaultProps<'StylesParams> =
        DefaultProps<obj, 'StylesParams>

    type DefaultProps =
        DefaultProps<obj, obj>

    type [<AllowNullLiteral>] DefaultProps<'StylesNames, 'StylesParams> =
        inherit MantineStyleSystemProps
        abstract className: string option with get, set
        abstract style: CSSProperties option with get, set
        abstract sx: U2<Sx, ResizeArray<Sx option>> option with get, set
        abstract classNames: ClassNames<'StylesNames> option with get, set
        abstract styles: Styles<'StylesNames, 'StylesParams> option with get, set
        abstract unstyled: bool option with get, set

module __theme_types_MantineColor =
    // type Tuple = __theme_types_Tuple.Tuple

    type DefaultMantineColor =
        U2<obj, string>

    type [<AllowNullLiteral>] MantineThemeColorsOverride =
        interface end

    type MantineThemeColors =
        obj

    type MantineColor =
        MantineThemeColors

// open __theme_types_MantineColor

open __theme_types_MantineColor

module __theme_types_MantineGradient =

    type [<AllowNullLiteral>] MantineGradient =
        abstract from: string with get, set
        abstract ``to``: string with get, set
        abstract deg: float option with get, set

    // open __theme_types_MantineGradient

// open __theme_types_MantineGradient

open __theme_types_MantineGradient

module __theme_types_MantineShadow =

    type MantineShadow =
        U2<MantineSize, obj>

module __theme_types_MantineSize =

    type [<StringEnum>] [<RequireQualifiedAccess>] MantineSize =
        | Xs
        | Sm
        | Md
        | Lg
        | Xl

    type MantineNumberSize =
        U2<MantineSize, float>

    type MantineSizes =
        Record<MantineSize, float>

// open __theme_types_MantineSize

open __theme_types_MantineSize

module __theme_types_MantineStyleSystem =
    // open __theme_types_MantineStyleSystem

    // type CSSProperties = React.CSSProperties
    type MantineColor = __theme_types_MantineColor.MantineColor

    type SystemProp<'Value> =
        U2<'Value, obj>

    type SpacingValue =
        U2<MantineNumberSize, obj>

    type [<AllowNullLiteral>] MantineStyleSystemProps =
        abstract m: SystemProp<SpacingValue> option with get, set
        abstract my: SystemProp<SpacingValue> option with get, set
        abstract mx: SystemProp<SpacingValue> option with get, set
        abstract mt: SystemProp<SpacingValue> option with get, set
        abstract mb: SystemProp<SpacingValue> option with get, set
        abstract ml: SystemProp<SpacingValue> option with get, set
        abstract mr: SystemProp<SpacingValue> option with get, set
        abstract p: SystemProp<SpacingValue> option with get, set
        abstract py: SystemProp<SpacingValue> option with get, set
        abstract px: SystemProp<SpacingValue> option with get, set
        abstract pt: SystemProp<SpacingValue> option with get, set
        abstract pb: SystemProp<SpacingValue> option with get, set
        abstract pl: SystemProp<SpacingValue> option with get, set
        abstract pr: SystemProp<SpacingValue> option with get, set
        abstract bg: SystemProp<MantineColor> option with get, set
        abstract c: SystemProp<MantineColor> option with get, set
        abstract opacity: SystemProp<CSSProperties> option with get, set
        abstract ff: SystemProp<CSSProperties> option with get, set
        abstract fz: SystemProp<SpacingValue> option with get, set
        abstract fw: SystemProp<CSSProperties> option with get, set
        abstract lts: SystemProp<CSSProperties> option with get, set
        abstract ta: SystemProp<CSSProperties> option with get, set
        abstract lh: SystemProp<CSSProperties> option with get, set
        abstract fs: SystemProp<CSSProperties> option with get, set
        abstract tt: SystemProp<CSSProperties> option with get, set
        abstract td: SystemProp<CSSProperties> option with get, set
        abstract w: SystemProp<CSSProperties> option with get, set
        abstract miw: SystemProp<CSSProperties> option with get, set
        abstract maw: SystemProp<CSSProperties> option with get, set
        abstract h: SystemProp<CSSProperties> option with get, set
        abstract mih: SystemProp<CSSProperties> option with get, set
        abstract mah: SystemProp<CSSProperties> option with get, set
        abstract bgsz: SystemProp<CSSProperties> option with get, set
        abstract bgp: SystemProp<CSSProperties> option with get, set
        abstract bgr: SystemProp<CSSProperties> option with get, set
        abstract bga: SystemProp<CSSProperties> option with get, set
        abstract pos: SystemProp<CSSProperties> option with get, set
        abstract top: SystemProp<CSSProperties> option with get, set
        abstract left: SystemProp<CSSProperties> option with get, set
        abstract bottom: SystemProp<CSSProperties> option with get, set
        abstract right: SystemProp<CSSProperties> option with get, set
        abstract inset: SystemProp<CSSProperties> option with get, set
        abstract display: SystemProp<CSSProperties> option with get, set

    type MantineStyleSystemSize =
        MantineStyleSystemProps


module __theme_types_MantineTheme =

    type [<StringEnum>] [<RequireQualifiedAccess>] LoaderType =
        | Bars
        | Oval
        | Dots

    type MantineThemeOther =
        Record<string, obj option>

    type MantineThemeComponents =
        Record<string, ThemeComponent>

    type [<AllowNullLiteral>] HeadingStyle =
        abstract fontSize: CSSProperties with get, set
        abstract fontWeight: CSSProperties with get, set
        abstract lineHeight: CSSProperties with get, set

    type [<RequireQualifiedAccess>] Shade =
        | N0 = 0
        | N1 = 1
        | N2 = 2
        | N3 = 3
        | N4 = 4
        | N5 = 5
        | N6 = 6
        | N7 = 7
        | N8 = 8
        | N9 = 9

    type [<AllowNullLiteral>] MantinePrimaryShade =
        abstract light: Shade with get, set
        abstract dark: Shade with get, set

    type [<AllowNullLiteral>] MantineFocusRingStyles =
        abstract styles: theme: MantineThemeBase -> CSSObject
        abstract resetStyles: theme: MantineThemeBase -> CSSObject
        abstract inputStyles: theme: MantineThemeBase -> CSSObject

    type [<AllowNullLiteral>] MantineThemeFunctions =
        abstract fontStyles: unit -> obj option
        abstract focusStyles: ?selector: string -> obj option
        abstract cover: ?offset: U2<float, string> -> obj option
        abstract themeColor: color: string * ?shade: float * ?primaryFallback: bool * ?useSplittedShade: bool -> string
        abstract rgba: color: string * alpha: float -> string
        abstract size: props: MantineThemeFunctionsSizeProps -> obj option
        abstract linearGradient: deg: float * [<ParamArray>] colors: ResizeArray<string> -> string
        abstract radialGradient: [<ParamArray>] colors: ResizeArray<string> -> string
        abstract gradient: ?gradient: MantineGradient -> string
        abstract smallerThan: breakpoint: MantineNumberSize -> string
        abstract largerThan: breakpoint: MantineNumberSize -> string
        abstract lighten: color: string * alpha: float -> string
        abstract darken: color: string * alpha: float -> string
        abstract radius: ?size: U2<MantineNumberSize, obj> -> U2<string, float>
        abstract variant: payload: VariantInput -> VariantOutput
        abstract primaryShade: ?colorScheme: ColorScheme -> Shade
        abstract hover: hoverStyle: CSSObject -> obj option
        abstract primaryColor: ?colorScheme: ColorScheme -> string
        abstract placeholderStyles: unit -> obj option

    type [<AllowNullLiteral>] MantineThemeFunctionsSizeProps =
        abstract size: U2<string, float> with get, set
        abstract sizes: Record<string, obj option> with get, set

    type [<AllowNullLiteral>] MantineTheme =
        abstract dir: MantineThemeDir with get, set
        abstract primaryShade: U2<Shade, MantinePrimaryShade> with get, set
        abstract focusRing: MantineThemeFocusRing with get, set
        abstract defaultRadius: U2<MantineNumberSize, obj> with get, set
        abstract loader: LoaderType with get, set
        abstract dateFormat: string with get, set
        abstract colorScheme: ColorScheme with get, set
        abstract white: string with get, set
        abstract black: string with get, set
        abstract colors: MantineThemeColors with get, set
        abstract fontFamily: CSSProperties with get, set
        abstract lineHeight: CSSProperties with get, set
        abstract transitionTimingFunction: CSSProperties with get, set
        abstract fontFamilyMonospace: CSSProperties with get, set
        abstract primaryColor: MantineThemeColors with get, set
        abstract respectReducedMotion: bool with get, set
        abstract cursorType: MantineThemeCursorType with get, set
        abstract defaultGradient: MantineGradient with get, set
        abstract fontSizes: MantineSizes with get, set
        abstract radius: MantineSizes with get, set
        abstract spacing: MantineSizes with get, set
        abstract breakpoints: MantineSizes with get, set
        abstract shadows: Record<MantineSize, string> with get, set
        abstract headings: MantineThemeHeadings with get, set
        abstract fn: MantineThemeFunctions with get, set
        abstract other: MantineThemeOther with get, set
        abstract activeStyles: CSSObject with get, set
        abstract datesLocale: string with get, set
        abstract components: MantineThemeComponents with get, set
        abstract globalStyles: (MantineTheme -> CSSObject) with get, set
        abstract focusRingStyles: MantineFocusRingStyles with get, set

    type [<AllowNullLiteral>] ThemeComponent =
        abstract defaultProps: U2<Record<string, obj option>, (MantineTheme -> Record<string, obj option>)> option with get, set
        abstract classNames: Record<string, string> option with get, set
        abstract styles: U2<Record<string, CSSObject>, (MantineTheme -> obj option -> Record<string, CSSObject>)> option with get, set

    type MantineThemeBase =
        Omit<MantineTheme, string>

    type [<AllowNullLiteral>] MantineThemeOverride =
        interface end

    type [<StringEnum>] [<RequireQualifiedAccess>] MantineThemeDir =
        | Ltr
        | Rtl

    type [<StringEnum>] [<RequireQualifiedAccess>] MantineThemeFocusRing =
        | Auto
        | Always
        | Never

    type [<StringEnum>] [<RequireQualifiedAccess>] MantineThemeCursorType =
        | Default
        | Pointer

    type [<AllowNullLiteral>] MantineThemeHeadingsSizes =
        abstract h1: HeadingStyle with get, set
        abstract h2: HeadingStyle with get, set
        abstract h3: HeadingStyle with get, set
        abstract h4: HeadingStyle with get, set
        abstract h5: HeadingStyle with get, set
        abstract h6: HeadingStyle with get, set

    type [<AllowNullLiteral>] MantineThemeHeadings =
        abstract fontFamily: CSSProperties with get, set
        abstract fontWeight: CSSProperties with get, set
        abstract sizes: MantineThemeHeadingsSizes with get, set

open __theme_types_MantineTheme

module __theme_types_Tuple =

    type _TupleOf<'T, 'N, 'R> =
        obj

    type Tuple<'T, 'N> =
        obj

module __tss_types_css_object =
    // module CSS = Csstype

    type [<AllowNullLiteral>] CSSObject =
        inherit CSSPropertiesWithMultiValues
        inherit CSSPseudos
        inherit CSSOthersObject
        inherit CSSTssSpecials

    type [<AllowNullLiteral>] CSSTssSpecials =
        abstract ref: string option with get, set

    type CSSProperties = obj
        // CSS.PropertiesFallback<U2<float, string>>

    type [<AllowNullLiteral>] CSSPropertiesWithMultiValues =
        interface end

    type [<AllowNullLiteral>] CSSPseudos =
        interface end

    type [<AllowNullLiteral>] ArrayCSSInterpolation =
        inherit Array<CSSInterpolation>

    type [<AllowNullLiteral>] ComponentSelector =
        abstract __emotion_styles: obj option with get, set

    type [<AllowNullLiteral>] Keyframes =
        interface end

    type [<AllowNullLiteral>] SerializedStyles =
        abstract name: string with get, set
        abstract styles: string with get, set
        abstract map: string option with get, set
        abstract next: SerializedStyles option with get, set

    type InterpolationPrimitive =
        U7<bool, float, string, ComponentSelector, Keyframes, SerializedStyles, CSSObject> option

    type CSSInterpolation =
        U2<InterpolationPrimitive, ArrayCSSInterpolation>

    type [<AllowNullLiteral>] CSSOthersObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertiesName: string -> CSSInterpolation with get, set

open __tss_types_css_object

module __tss_types_css =

    type [<AllowNullLiteral>] CSS =
        [<Emit "$0($1...)">] abstract Invoke: template: TemplateStringsArray * [<ParamArray>] args: ResizeArray<CSSInterpolation> -> string
        [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] args: ResizeArray<CSSInterpolation> -> string

// open __tss_types_css

// module __tss_types_Selectors =
//
//     type Selectors<'T> =
//         ReturnType<'T>

module __theme_functions_fns_index =
    type fontStyles = __theme_functions_fns_font_styles_font_styles.fontStyles
    type focusStyles = __theme_functions_fns_focus_styles_focus_styles.focusStyles
    type themeColor = __theme_functions_fns_theme_color_theme_color.themeColor
    type linearGradient = __theme_functions_fns_gradient_gradient.linearGradient
    type radialGradient = __theme_functions_fns_gradient_gradient.radialGradient
    type gradient = __theme_functions_fns_gradient_gradient.gradient
    type smallerThan = __theme_functions_fns_breakpoints_breakpoints.smallerThan
    type largerThan = __theme_functions_fns_breakpoints_breakpoints.largerThan
    type rgba = __theme_functions_fns_rgba_rgba.rgba
    type size = __theme_functions_fns_size_size.size
    type cover = __theme_functions_fns_cover_cover.cover
    type darken = __theme_functions_fns_darken_darken.darken
    type lighten = __theme_functions_fns_lighten_lighten.lighten
    type radius = __theme_functions_fns_radius_radius.radius
    type variant = __theme_functions_fns_variant_variant.variant
    type primaryShade = __theme_functions_fns_primary_shade_primary_shade.primaryShade
    type primaryColor = __theme_functions_fns_primary_color_primary_color.primaryColor
    type hover = __theme_functions_fns_hover_hover.hover
    type placeholderStyles = __theme_functions_fns_placeholder_styles_placeholder_styles.placeholderStyles

    type [<AllowNullLiteral>] IExports =
        abstract fns: IExportsFns

    type [<AllowNullLiteral>] IExportsFns =
        abstract fontStyles: obj with get, set
        abstract themeColor: obj with get, set
        abstract focusStyles: obj with get, set
        abstract linearGradient: obj with get, set
        abstract radialGradient: obj with get, set
        abstract smallerThan: obj with get, set
        abstract largerThan: obj with get, set
        abstract rgba: obj with get, set
        abstract size: obj with get, set
        abstract cover: obj with get, set
        abstract darken: obj with get, set
        abstract lighten: obj with get, set
        abstract radius: obj with get, set
        abstract variant: obj with get, set
        abstract primaryShade: obj with get, set
        abstract hover: obj with get, set
        abstract gradient: obj with get, set
        abstract primaryColor: obj with get, set
        abstract placeholderStyles: obj with get, set

module __theme_utils_filter_props_filter_props =

    type [<AllowNullLiteral>] IExports =
        abstract filterProps: props: 'T -> FilterPropsRes<'T>

    type [<AllowNullLiteral>] FilterPropsRes<'T> =
        interface end

module __theme_utils_get_default_z_index_get_default_z_index =

    type [<AllowNullLiteral>] IExports =
        abstract elevations: IExportsElevations
        abstract getDefaultZIndex: level: obj -> GetDefaultZIndexReturn

    type [<RequireQualifiedAccess>] GetDefaultZIndexReturn =
        | N100 = 100
        | N200 = 200
        | N300 = 300
        | N400 = 400
        | N9999 = 9999

    type [<AllowNullLiteral>] IExportsElevations =
        abstract app: obj
        abstract modal: obj
        abstract popover: obj
        abstract overlay: obj
        abstract max: obj

module __theme_utils_merge_theme_merge_theme =
    type MantineThemeOverride = __theme_types.MantineThemeOverride
    type MantineThemeBase = __theme_types.MantineThemeBase
    type MantineTheme = __theme_types.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract mergeTheme: currentTheme: MantineThemeBase * ?themeOverride: MantineThemeOverride -> MantineThemeBase
        abstract mergeThemeWithFunctions: currentTheme: MantineThemeBase * ?themeOverride: MantineThemeOverride -> MantineTheme

module __theme_utils_to_rgba_to_rgba =

    type [<AllowNullLiteral>] IExports =
        abstract toRgba: color: string -> RGBA

    type [<AllowNullLiteral>] RGBA =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float with get, set

module __tss_utils_merge_class_names_merge_class_names =
    type useMantineProviderStyles = __theme_MantineProvider.useMantineProviderStyles

    type [<AllowNullLiteral>] IExports =
        abstract mergeClassNames: p0: Input<'T> -> 'T

    type [<AllowNullLiteral>] Input<'T> =
        abstract cx: [<ParamArray>] classNames: obj option -> string
        abstract classes: 'T with get, set
        abstract context: ReturnType<obj> with get, set
        abstract classNames: obj with get, set
        abstract name: U2<string, ResizeArray<string>> with get, set
        abstract cache: EmotionCache with get, set

module __tss_utils_use_guaranteed_memo_use_guaranteed_memo =

    type [<AllowNullLiteral>] IExports =
        abstract useGuaranteedMemo: fn: (unit -> 'T) * deps: React.DependencyList -> 'T

module __theme_functions_fns_breakpoints_breakpoints =

    type [<AllowNullLiteral>] IExports =
        abstract largerThan: theme: MantineThemeBase -> (MantineNumberSize -> string)
        abstract smallerThan: theme: MantineThemeBase -> (MantineNumberSize -> string)

module __theme_functions_fns_cover_cover =

    type [<AllowNullLiteral>] IExports =
        abstract cover: ?offset: U2<float, string> -> CSSObject

module __theme_functions_fns_darken_darken =

    type [<AllowNullLiteral>] IExports =
        abstract darken: color: string * alpha: float -> string

module __theme_functions_fns_focus_styles_focus_styles =

    type [<AllowNullLiteral>] IExports =
        abstract focusStyles: theme: MantineThemeBase -> (string -> CSSObject)

module __theme_functions_fns_font_styles_font_styles =

    type [<AllowNullLiteral>] IExports =
        abstract fontStyles: theme: MantineThemeBase -> (unit -> CSSObject)

module __theme_functions_fns_gradient_gradient =

    type [<AllowNullLiteral>] IExports =
        abstract linearGradient: deg: float * [<ParamArray>] colors: ResizeArray<string> -> string
        abstract radialGradient: [<ParamArray>] colors: ResizeArray<string> -> string
        abstract gradient: theme: MantineThemeBase -> (MantineGradient -> string)

module __theme_functions_fns_hover_hover =

    type [<AllowNullLiteral>] IExports =
        abstract hover: hoverStyle: CSSObject -> HoverReturn

    type [<AllowNullLiteral>] HoverReturn =
        abstract ``@media (hover: hover)``: HoverReturn_media__hover__hover_ with get, set
        abstract ``@media (hover: none)``: HoverReturn_media__hover__none_ with get, set

    type [<AllowNullLiteral>] HoverReturn_media__hover__hover_ =
        abstract ``&:hover``: CSSObject with get, set

    type [<AllowNullLiteral>] HoverReturn_media__hover__none_ =
        abstract ``&:active``: CSSObject with get, set

module __theme_functions_fns_lighten_lighten =

    type [<AllowNullLiteral>] IExports =
        abstract lighten: color: string * alpha: float -> string

module __theme_functions_fns_placeholder_styles_placeholder_styles =

    type [<AllowNullLiteral>] IExports =
        abstract placeholderStyles: theme: MantineThemeBase -> (unit -> CSSObject)

module __theme_functions_fns_primary_color_primary_color =

    type [<AllowNullLiteral>] IExports =
        abstract primaryColor: theme: MantineThemeBase -> (IExportsPrimaryColor -> string)

    type [<StringEnum>] [<RequireQualifiedAccess>] IExportsPrimaryColor =
        | Light
        | Dark

module __theme_functions_fns_primary_shade_primary_shade =

    type [<AllowNullLiteral>] IExports =
        abstract primaryShade: theme: MantineThemeBase -> (IExportsPrimaryShade -> IExportsPrimaryShade2)

    type [<StringEnum>] [<RequireQualifiedAccess>] IExportsPrimaryShade =
        | Light
        | Dark

    type [<RequireQualifiedAccess>] IExportsPrimaryShade2 =
        | N0 = 0
        | N1 = 1
        | N2 = 2
        | N3 = 3
        | N4 = 4
        | N5 = 5
        | N6 = 6
        | N7 = 7
        | N8 = 8
        | N9 = 9

module __theme_functions_fns_radius_radius =

    type [<AllowNullLiteral>] IExports =
        abstract radius: theme: MantineThemeBase -> (U2<MantineNumberSize, obj> -> U2<string, float>)

module __theme_functions_fns_rgba_rgba =

    type [<AllowNullLiteral>] IExports =
        abstract rgba: color: string * alpha: float -> string

module __theme_functions_fns_size_size =

    type [<AllowNullLiteral>] IExports =
        abstract size: props: GetSize -> obj option

    type [<AllowNullLiteral>] GetSize =
        abstract size: U2<string, float> with get, set
        abstract sizes: Record<string, obj option> with get, set

module __theme_functions_fns_theme_color_theme_color =

    type [<AllowNullLiteral>] IExports =
        abstract themeColor: theme: MantineThemeBase -> (string -> float -> bool -> bool -> string)



module __theme_functions_fns_variant_variant =
    type CSSProperties = React.CSSProperties

    type [<AllowNullLiteral>] IExports =
        abstract variant: theme: MantineThemeBase -> (VariantInput -> VariantOutput)

    type [<AllowNullLiteral>] VariantInput =
        abstract variant: VariantInputVariant with get, set
        abstract color: MantineColor option with get, set
        abstract gradient: MantineGradient option with get, set
        abstract primaryFallback: bool option with get, set

    type [<AllowNullLiteral>] VariantOutput =
        abstract border: CSSProperties with get, set
        abstract background: CSSProperties with get, set
        abstract color: CSSProperties with get, set
        abstract hover: CSSProperties with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] VariantInputVariant =
        | Filled
        | Light
        | Outline
        | Default
        | Gradient
        | White
        | Subtle
        | Transparent
//
// module __theme_functions_fns_gradient_get_gradient_color_stops_get_gradient_color_stops =
//
//     type [<AllowNullLiteral>] IExports =
//         abstract getGradientColorStops: colors: ResizeArray<string> -> string

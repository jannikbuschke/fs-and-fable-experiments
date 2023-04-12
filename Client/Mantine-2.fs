// ts2fable 0.7.1
module rec Mantine-2
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types


module __Accordion_Accordion_context =
    type MantineNumberSize = __Accordion_@mantine_styles.MantineNumberSize
    type ClassNames = __Accordion_@mantine_styles.ClassNames
    type Styles = __Accordion_@mantine_styles.Styles
    type AccordionChevronPosition = __Accordion_Accordion_types.AccordionChevronPosition
    type AccordionHeadingOrder = __Accordion_Accordion_types.AccordionHeadingOrder
    type AccordionVariant = __Accordion_Accordion_types.AccordionVariant

    type [<AllowNullLiteral>] IExports =
        abstract AccordionContextProvider: (IExportsAccordionContextProvider -> JSX.Element)
        abstract useAccordionContext: (unit -> AccordionContext)

    type [<AllowNullLiteral>] AccordionContext =
        abstract loop: bool with get, set
        abstract transitionDuration: float with get, set
        abstract disableChevronRotation: bool with get, set
        abstract chevronPosition: AccordionChevronPosition with get, set
        abstract chevronSize: float with get, set
        abstract order: AccordionHeadingOrder with get, set
        abstract chevron: React.ReactNode with get, set
        abstract variant: AccordionVariant with get, set
        abstract radius: MantineNumberSize with get, set
        abstract onChange: value: string -> unit
        abstract isItemActive: value: string -> bool
        abstract getControlId: value: string -> string
        abstract getRegionId: value: string -> string
        abstract classNames: ClassNames<AccordionStylesNames> with get, set
        abstract styles: Styles<AccordionStylesNames> with get, set
        abstract unstyled: bool with get, set

    type [<AllowNullLiteral>] IExportsAccordionContextProvider =
        abstract value: AccordionContext with get, set
        abstract children: obj with get, set

module __Accordion_Accordion =
    type DefaultProps = __Accordion_@mantine_styles.DefaultProps
    type AccordionProviderProps = __Accordion_AccordionProvider.AccordionProviderProps
    type AccordionItemStylesNames = __Accordion_AccordionItem_AccordionItem.AccordionItemStylesNames
    type AccordionControlStylesNames = __Accordion_AccordionControl_AccordionControl.AccordionControlStylesNames
    type AccordionPanel = __Accordion_AccordionPanel_AccordionPanel.AccordionPanel
    type AccordionPanelStylesNames = __Accordion_AccordionPanel_AccordionPanel.AccordionPanelStylesNames
    type AccordionStylesParams = __Accordion_Accordion_types.AccordionStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Accordion: props: AccordionProps<'Multiple> -> JSX.Element

    type AccordionStylesNames =
        U3<AccordionItemStylesNames, AccordionPanelStylesNames, AccordionControlStylesNames>

    type AccordionProps =
        AccordionProps<obj>

    type [<AllowNullLiteral>] AccordionProps<'Multiple> =
        inherit AccordionProviderProps<'Multiple>
        inherit DefaultProps<AccordionStylesNames, AccordionStylesParams>
        inherit Omit<React.ComponentPropsWithoutRef<string>, AccordionProviderProps<'Multiple>>

    module Accordion =

        type [<AllowNullLiteral>] IExports =
            abstract Item: React.ForwardRefExoticComponent<obj>
            abstract Control: React.ForwardRefExoticComponent<obj>
            abstract Panel: obj
            abstract displayName: string

module __Accordion_Accordion_errors =

    type [<AllowNullLiteral>] IExports =
        abstract ACCORDION_ERRORS: IExportsACCORDION_ERRORS

    type [<AllowNullLiteral>] IExportsACCORDION_ERRORS =
        abstract context: string with get, set
        abstract itemContext: string with get, set
        abstract value: string with get, set

module __Accordion_Accordion_types =
    type MantineNumberSize = __Accordion_@mantine_styles.MantineNumberSize

    type AccordionValue<'Multiple> =
        obj

    type [<RequireQualifiedAccess>] AccordionHeadingOrder =
        | N2 = 2
        | N3 = 3
        | N4 = 4
        | N5 = 5
        | N6 = 6

    type [<StringEnum>] [<RequireQualifiedAccess>] AccordionChevronPosition =
        | Left
        | Right

    type [<StringEnum>] [<RequireQualifiedAccess>] AccordionVariant =
        | Default
        | Contained
        | Filled
        | Separated

    type [<AllowNullLiteral>] AccordionStylesParams =
        abstract variant: AccordionVariant with get, set
        abstract radius: MantineNumberSize option with get, set

module __Accordion_AccordionItem_context =

    type [<AllowNullLiteral>] IExports =
        abstract AccordionItemContextProvider: (IExportsAccordionItemContextProvider -> JSX.Element)
        abstract useAccordionItemContext: (unit -> AccordionItemContext)

    type [<AllowNullLiteral>] AccordionItemContext =
        abstract value: string with get, set

    type [<AllowNullLiteral>] IExportsAccordionItemContextProvider =
        abstract value: AccordionItemContext with get, set
        abstract children: obj with get, set

module __Accordion_AccordionProvider =
    type MantineNumberSize = __Accordion_@mantine_styles.MantineNumberSize
    type ClassNames = __Accordion_@mantine_styles.ClassNames
    type Styles = __Accordion_@mantine_styles.Styles
    type AccordionValue = __Accordion_Accordion_types.AccordionValue
    type AccordionChevronPosition = __Accordion_Accordion_types.AccordionChevronPosition
    type AccordionHeadingOrder = __Accordion_Accordion_types.AccordionHeadingOrder
    type AccordionVariant = __Accordion_Accordion_types.AccordionVariant

    type [<AllowNullLiteral>] IExports =
        abstract AccordionProvider: p0: _AccordionProviderProps<'Multiple> -> JSX.Element

    type AccordionProviderProps =
        AccordionProviderProps<obj>

    type [<AllowNullLiteral>] AccordionProviderProps<'Multiple> =
        /// Base id, used to generate ids that connect labels with controls, by default generated randomly
        abstract id: string option with get, set
        /// Determines whether arrow key presses should loop though items (first to last and last to first)
        abstract loop: bool option with get, set
        /// Accordion content
        abstract children: React.ReactNode with get, set
        /// Determines whether multiple items can be opened at a time
        abstract multiple: 'Multiple option with get, set
        /// Value for controlled component
        abstract value: AccordionValue<'Multiple> option with get, set
        /// Default value for uncontrolled component
        abstract defaultValue: AccordionValue<'Multiple> option with get, set
        /// Callback for controlled component
        abstract onChange: value: AccordionValue<'Multiple> -> unit
        /// Transition duration in ms, set 0 to disable transitions
        abstract transitionDuration: float option with get, set
        /// Determines whether chevron rotation should be disabled
        abstract disableChevronRotation: bool option with get, set
        /// Determines position of the chevron
        abstract chevronPosition: AccordionChevronPosition option with get, set
        /// Chevron size in px
        abstract chevronSize: float option with get, set
        /// Heading order, has no effect on visuals
        abstract order: AccordionHeadingOrder option with get, set
        /// Replaces chevron on all items
        abstract chevron: React.ReactNode option with get, set
        /// Controls visuals
        abstract variant: AccordionVariant option with get, set
        /// border-radius from theme.radius or number to set value in px, will not be applied to default variant
        abstract radius: MantineNumberSize option with get, set

    type _AccordionProviderProps =
        _AccordionProviderProps<obj>

    type [<AllowNullLiteral>] _AccordionProviderProps<'Multiple> =
        inherit AccordionProviderProps<'Multiple>
        abstract classNames: ClassNames<AccordionStylesNames> option with get, set
        abstract styles: Styles<AccordionStylesNames> option with get, set
        abstract unstyled: bool option with get, set

module __Accordion_ChevronIcon =

    type [<AllowNullLiteral>] IExports =
        abstract ChevronIcon: props: React.ComponentPropsWithoutRef<string> -> JSX.Element

module __ActionIcon_ActionIcon =
    type DefaultProps = __ActionIcon_@mantine_styles.DefaultProps
    type MantineNumberSize = __ActionIcon_@mantine_styles.MantineNumberSize
    type MantineColor = __ActionIcon_@mantine_styles.MantineColor
    type Selectors = __ActionIcon_@mantine_styles.Selectors
    type MantineGradient = __ActionIcon_@mantine_styles.MantineGradient
    type ActionIconVariant = __ActionIcon_ActionIcon_styles.ActionIconVariant
    type ActionIconStylesParams = __ActionIcon_ActionIcon_styles.ActionIconStylesParams
    type LoaderProps = Loader.LoaderProps

    type [<AllowNullLiteral>] IExports =
        abstract _ActionIcon: React.ForwardRefExoticComponent<obj>
        abstract ActionIcon: obj

    type ActionIconStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] ActionIconProps =
        inherit DefaultProps<ActionIconStylesNames, ActionIconStylesParams>
        /// Icon
        abstract children: React.ReactNode option with get, set
        /// Controls appearance
        abstract variant: ActionIconVariant option with get, set
        /// Key of theme.colors
        abstract color: MantineColor option with get, set
        /// Controls gradient settings in gradient variant only
        abstract gradient: MantineGradient option with get, set
        /// Button border-radius from theme or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set
        /// Predefined icon size or number to set width and height in px
        abstract size: MantineNumberSize option with get, set
        /// Props spread to Loader component
        abstract loaderProps: LoaderProps option with get, set
        /// Indicates loading state
        abstract loading: bool option with get, set
        /// Indicates disabled state
        abstract disabled: bool option with get, set

module __ActionIcon_ActionIcon_styles =
    type MantineNumberSize = __ActionIcon_@mantine_styles.MantineNumberSize
    type MantineColor = __ActionIcon_@mantine_styles.MantineColor
    type MantineTheme = __ActionIcon_@mantine_styles.MantineTheme
    type MantineGradient = __ActionIcon_@mantine_styles.MantineGradient

    type [<AllowNullLiteral>] IExports =
        abstract ACTION_ICON_VARIANTS: string * string * string * string * string * string * string
        abstract sizes: IExportsSizes
        abstract _default: (ActionIconStylesParams -> obj -> IExports_default)

    type ActionIconVariant =
        obj

    type [<AllowNullLiteral>] ActionIconStylesParams =
        abstract color: MantineColor with get, set
        abstract size: MantineNumberSize with get, set
        abstract radius: MantineNumberSize with get, set
        abstract variant: ActionIconVariant with get, set
        abstract gradient: MantineGradient with get, set

    type [<AllowNullLiteral>] IExportsSizes =
        abstract xs: float with get, set
        abstract sm: float with get, set
        abstract md: float with get, set
        abstract lg: float with get, set
        abstract xl: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Affix_Affix =
    type DefaultProps = __Affix_@mantine_styles.DefaultProps
    type MantineStyleSystemSize = __Affix_@mantine_styles.MantineStyleSystemSize

    type [<AllowNullLiteral>] IExports =
        abstract Affix: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] AffixProps =
        inherit Omit<DefaultProps, MantineStyleSystemSize>
        inherit React.ComponentPropsWithoutRef<string>
        /// Element where portal should be rendered, by default new div element is created and appended to document.body
        abstract target: HTMLDivElement option with get, set
        /// Root element z-index property
        abstract zIndex: React.CSSProperties option with get, set
        /// Determines whether component should be rendered within portal, defaults to true
        abstract withinPortal: bool option with get, set
        /// Fixed position in px, defaults to { bottom: 0, right: 0 }
        abstract position: AffixPropsPosition option with get, set

    type [<AllowNullLiteral>] AffixPropsPosition =
        abstract top: U2<string, float> option with get, set
        abstract left: U2<string, float> option with get, set
        abstract bottom: U2<string, float> option with get, set
        abstract right: U2<string, float> option with get, set

module __Alert_Alert =
    type DefaultProps = __Alert_@mantine_styles.DefaultProps
    type MantineColor = __Alert_@mantine_styles.MantineColor
    type Selectors = __Alert_@mantine_styles.Selectors
    type MantineNumberSize = __Alert_@mantine_styles.MantineNumberSize
    type AlertStylesParams = __Alert_Alert_styles.AlertStylesParams
    type AlertVariant = __Alert_Alert_styles.AlertVariant

    type [<AllowNullLiteral>] IExports =
        abstract Alert: React.ForwardRefExoticComponent<obj>

    type AlertStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] AlertProps =
        inherit DefaultProps<AlertStylesNames, AlertStylesParams>
        inherit Omit<React.ComponentPropsWithoutRef<string>, string>
        /// Alert title
        abstract title: React.ReactNode option with get, set
        /// Controls Alert background, color and border styles, defaults to light
        abstract variant: AlertVariant option with get, set
        /// Alert message
        abstract children: React.ReactNode with get, set
        /// Color from theme.colors
        abstract color: MantineColor option with get, set
        /// Icon displayed next to title
        abstract icon: React.ReactNode option with get, set
        /// True to display close button
        abstract withCloseButton: bool option with get, set
        /// Called when close button is clicked
        abstract onClose: unit -> unit
        /// Close button aria-label
        abstract closeButtonLabel: string option with get, set
        /// Radius from theme.radius, or number to set border-radius in px, defaults to theme.defaultRadius
        abstract radius: MantineNumberSize option with get, set

module __Alert_Alert_styles =
    type MantineColor = __Alert_@mantine_styles.MantineColor
    type MantineNumberSize = __Alert_@mantine_styles.MantineNumberSize
    type MantineTheme = __Alert_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (AlertStylesParams -> obj -> IExports_default)

    type [<StringEnum>] [<RequireQualifiedAccess>] AlertVariant =
        | Filled
        | Outline
        | Light

    type [<AllowNullLiteral>] AlertStylesParams =
        abstract color: MantineColor with get, set
        abstract radius: MantineNumberSize with get, set
        abstract variant: AlertVariant with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract wrapper: string with get, set
        abstract body: string with get, set
        abstract title: string with get, set
        abstract label: string with get, set
        abstract icon: string with get, set
        abstract message: string with get, set
        abstract closeButton: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Anchor_Anchor =
    type TextProps = __Text_Text.TextProps

    type [<AllowNullLiteral>] IExports =
        abstract _Anchor: React.ForwardRefExoticComponent<obj>
        abstract Anchor: obj

    type [<AllowNullLiteral>] AnchorProps =
        inherit TextProps
        abstract children: React.ReactNode option with get, set

module __Anchor_Anchor_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (unit -> obj -> IExports_default)

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __AppShell_AppShell_context =

    type [<AllowNullLiteral>] IExports =
        abstract AppShellProvider: obj
        abstract useAppShellContext: unit -> AppShellContextValue

    type [<AllowNullLiteral>] AppShellContextValue =
        abstract zIndex: React.CSSProperties with get, set
        abstract ``fixed``: bool with get, set
        abstract layout: AppShellContextValueLayout with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] AppShellContextValueLayout =
        | Default
        | Alt

module __AppShell_AppShell =
    type MantineNumberSize = __AppShell_@mantine_styles.MantineNumberSize
    type DefaultProps = __AppShell_@mantine_styles.DefaultProps
    type Selectors = __AppShell_@mantine_styles.Selectors
    type MantineStyleSystemSize = __AppShell_@mantine_styles.MantineStyleSystemSize

    type [<AllowNullLiteral>] IExports =
        abstract AppShell: React.ForwardRefExoticComponent<obj>

    type AppShellStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] AppShellProps =
        inherit Omit<DefaultProps<AppShellStylesNames>, MantineStyleSystemSize>
        /// Determines how Navbar and Aside components are positioned relative to Header and Footer components
        abstract layout: AppShellPropsLayout option with get, set
        /// <Navbar /> component
        abstract navbar: React.ReactElement option with get, set
        /// <Aside /> component
        abstract aside: React.ReactElement option with get, set
        /// <Header /> component
        abstract header: React.ReactElement option with get, set
        /// <Footer /> component
        abstract footer: React.ReactElement option with get, set
        /// zIndex prop passed to Navbar and Header components
        abstract zIndex: React.CSSProperties option with get, set
        /// true to switch from static layout to fixed
        abstract ``fixed``: bool option with get, set
        /// true to hide all AppShell parts and render only children
        abstract hidden: bool option with get, set
        /// AppShell content
        abstract children: React.ReactNode with get, set
        /// Content padding
        abstract padding: MantineNumberSize option with get, set
        /// Breakpoint at which Navbar component should no longer be offset with padding-left, applicable only for fixed position
        abstract navbarOffsetBreakpoint: MantineNumberSize option with get, set
        /// Breakpoint at which Aside component should no longer be offset with padding-right, applicable only for fixed position
        abstract asideOffsetBreakpoint: MantineNumberSize option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] AppShellPropsLayout =
        | Default
        | Alt

module __AppShell_AppShell_styles =
    type MantineNumberSize = __AppShell_@mantine_styles.MantineNumberSize
    type MantineTheme = __AppShell_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (AppShellStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] AppShellStylesParams =
        abstract padding: MantineNumberSize with get, set
        abstract ``fixed``: bool with get, set
        abstract navbarOffsetBreakpoint: MantineNumberSize with get, set
        abstract asideOffsetBreakpoint: MantineNumberSize with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract body: string with get, set
        abstract main: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __AspectRatio_AspectRatio =
    type DefaultProps = __AspectRatio_@mantine_styles.DefaultProps

    type [<AllowNullLiteral>] IExports =
        abstract AspectRatio: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] AspectRatioProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// Aspect ratio, e.g. 16 / 9, 4 / 3, 1920 / 1080
        abstract ratio: float with get, set

module __AspectRatio_AspectRatio_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (AspectRatioStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] AspectRatioStylesParams =
        abstract ratio: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Autocomplete_Autocomplete =
    type DefaultProps = __Autocomplete_@mantine_styles.DefaultProps
    type InputWrapperBaseProps = Input.InputWrapperBaseProps
    type InputSharedProps = Input.InputSharedProps
    type SelectStylesNames = Select.SelectStylesNames
    type SelectSharedProps = __Select_Select.SelectSharedProps

    type [<AllowNullLiteral>] IExports =
        abstract defaultFilter: value: string * item: AutocompleteItem -> bool
        abstract Autocomplete: React.ForwardRefExoticComponent<obj>

    type AutocompleteStylesNames =
        SelectStylesNames

    type [<AllowNullLiteral>] AutocompleteItem =
        abstract value: string with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

    type [<AllowNullLiteral>] AutocompleteProps =
        inherit DefaultProps<AutocompleteStylesNames>
        inherit InputSharedProps
        inherit InputWrapperBaseProps
        inherit SelectSharedProps<AutocompleteItem, string>
        inherit Omit<React.ComponentPropsWithoutRef<string>, AutocompletePropsOmit>
        /// Maximum dropdown height
        abstract maxDropdownHeight: U2<float, string> option with get, set
        /// Change dropdown component, can be used to add native scrollbars
        abstract dropdownComponent: obj option with get, set
        /// Called when item from dropdown was selected
        abstract onItemSubmit: item: AutocompleteItem -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] AutocompletePropsOmit =
        | Size
        | OnChange
        | Value
        | DefaultValue

module __Autocomplete_Autocomplete_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (unit -> obj -> IExports_default)

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract wrapper: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Avatar_Avatar =
    type DefaultProps = __Avatar_@mantine_styles.DefaultProps
    type MantineNumberSize = __Avatar_@mantine_styles.MantineNumberSize
    type MantineColor = __Avatar_@mantine_styles.MantineColor
    type Selectors = __Avatar_@mantine_styles.Selectors
    type MantineGradient = __Avatar_@mantine_styles.MantineGradient
    type AvatarGroup = __Avatar_AvatarGroup_AvatarGroup.AvatarGroup
    type AvatarStylesParams = __Avatar_Avatar_styles.AvatarStylesParams
    type AvatarVariant = __Avatar_Avatar_styles.AvatarVariant

    type [<AllowNullLiteral>] IExports =
        abstract _Avatar: obj option
        abstract Avatar: obj

    type AvatarStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] AvatarProps =
        inherit DefaultProps<AvatarStylesNames, AvatarStylesParams>
        /// Image url
        abstract src: string option with get, set
        /// Image alt text or title for placeholder variant
        abstract alt: string option with get, set
        /// Avatar width and height
        abstract size: MantineNumberSize option with get, set
        /// Value from theme.radius or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set
        /// Color from theme.colors used for letter and icon placeholders
        abstract color: MantineColor option with get, set
        /// Controls appearance
        abstract variant: AvatarVariant option with get, set
        /// Controls gradient settings in gradient variant only
        abstract gradient: MantineGradient option with get, set
        /// img element attributes
        abstract imageProps: Record<string, obj option> option with get, set
        /// Custom placeholder
        abstract children: React.ReactNode option with get, set

module __Avatar_Avatar_styles =
    type MantineNumberSize = __Avatar_@mantine_styles.MantineNumberSize
    type MantineColor = __Avatar_@mantine_styles.MantineColor
    type MantineTheme = __Avatar_@mantine_styles.MantineTheme
    type MantineGradient = __Avatar_@mantine_styles.MantineGradient

    type [<AllowNullLiteral>] IExports =
        abstract AVATAR_VARIANTS: string * string * string * string
        abstract sizes: IExportsSizes
        abstract _default: (AvatarStylesParams -> obj -> IExports_default)

    type AvatarVariant =
        obj

    type [<AllowNullLiteral>] AvatarStylesParams =
        abstract size: MantineNumberSize with get, set
        abstract radius: MantineNumberSize with get, set
        abstract color: MantineColor with get, set
        abstract withinGroup: bool with get, set
        abstract spacing: MantineNumberSize with get, set
        abstract variant: AvatarVariant with get, set
        abstract gradient: MantineGradient with get, set

    type [<AllowNullLiteral>] IExportsSizes =
        abstract xs: float with get, set
        abstract sm: float with get, set
        abstract md: float with get, set
        abstract lg: float with get, set
        abstract xl: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract image: string with get, set
        abstract placeholder: string with get, set
        abstract placeholderIcon: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Avatar_AvatarPlaceholderIcon =

    type [<AllowNullLiteral>] IExports =
        abstract AvatarPlaceholderIcon: props: React.ComponentPropsWithoutRef<string> -> JSX.Element

module __BackgroundImage_BackgroundImage =
    type DefaultProps = __BackgroundImage_@mantine_styles.DefaultProps
    type MantineNumberSize = __BackgroundImage_@mantine_styles.MantineNumberSize

    type [<AllowNullLiteral>] IExports =
        abstract _BackgroundImage: React.ForwardRefExoticComponent<obj>
        abstract BackgroundImage: obj

    type [<AllowNullLiteral>] BackgroundImageProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// Image url
        abstract src: string with get, set
        /// Key of theme.radius or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set

module __Badge_Badge =
    type DefaultProps = __Badge_@mantine_styles.DefaultProps
    type MantineSize = __Badge_@mantine_styles.MantineSize
    type MantineNumberSize = __Badge_@mantine_styles.MantineNumberSize
    type MantineGradient = __Badge_@mantine_styles.MantineGradient
    type MantineColor = __Badge_@mantine_styles.MantineColor
    type Selectors = __Badge_@mantine_styles.Selectors
    type BadgeStylesParams = __Badge_Badge_styles.BadgeStylesParams
    type BadgeVariant = __Badge_Badge_styles.BadgeVariant

    type [<AllowNullLiteral>] IExports =
        abstract _Badge: React.ForwardRefExoticComponent<obj>
        abstract Badge: obj

    type BadgeStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] BadgeProps =
        inherit DefaultProps<BadgeStylesNames, BadgeStylesParams>
        /// Key of theme.colors
        abstract color: MantineColor option with get, set
        /// Controls appearance
        abstract variant: BadgeVariant option with get, set
        /// Controls gradient, applied to gradient variant only
        abstract gradient: MantineGradient option with get, set
        /// Badge height and font size
        abstract size: MantineSize option with get, set
        /// Key of theme.radius or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set
        /// Sets badge width to 100% of parent element, hides overflow text with text-overflow: ellipsis
        abstract fullWidth: bool option with get, set
        /// Section rendered on the left side of label
        abstract leftSection: React.ReactNode option with get, set
        /// Section rendered on the right side of label
        abstract rightSection: React.ReactNode option with get, set
        /// Badge label
        abstract children: React.ReactNode option with get, set

module __Badge_Badge_styles =
    type MantineSize = __Badge_@mantine_styles.MantineSize
    type MantineNumberSize = __Badge_@mantine_styles.MantineNumberSize
    type MantineColor = __Badge_@mantine_styles.MantineColor
    type MantineGradient = __Badge_@mantine_styles.MantineGradient
    type MantineTheme = __Badge_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (BadgeStylesParams -> obj -> IExports_default)

    type [<StringEnum>] [<RequireQualifiedAccess>] BadgeVariant =
        | Light
        | Filled
        | Outline
        | Dot
        | Gradient

    type [<AllowNullLiteral>] BadgeStylesParams =
        abstract color: MantineColor with get, set
        abstract size: MantineSize with get, set
        abstract radius: MantineNumberSize with get, set
        abstract gradient: MantineGradient with get, set
        abstract variant: BadgeVariant with get, set
        abstract fullWidth: bool with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract leftSection: string with get, set
        abstract rightSection: string with get, set
        abstract inner: string with get, set
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Blockquote_Blockquote =
    type DefaultProps = __Blockquote_@mantine_styles.DefaultProps
    type MantineColor = __Blockquote_@mantine_styles.MantineColor
    type Selectors = __Blockquote_@mantine_styles.Selectors
    type BlockquoteStylesParams = __Blockquote_Blockquote_styles.BlockquoteStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Blockquote: React.ForwardRefExoticComponent<obj>

    type BlockquoteStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] BlockquoteProps =
        inherit DefaultProps<BlockquoteStylesNames, BlockquoteStylesParams>
        inherit Omit<React.ComponentPropsWithoutRef<string>, string>
        /// Icon color from theme
        abstract color: MantineColor option with get, set
        /// Icon, defaults to quote icon
        abstract icon: React.ReactNode option with get, set
        /// Describe a reference to a cited quote
        abstract cite: React.ReactNode option with get, set

module __Blockquote_Blockquote_styles =
    type MantineColor = __Blockquote_@mantine_styles.MantineColor

    type [<AllowNullLiteral>] IExports =
        abstract _default: (BlockquoteStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] BlockquoteStylesParams =
        abstract color: MantineColor with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract inner: string with get, set
        abstract body: string with get, set
        abstract icon: string with get, set
        abstract cite: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Blockquote_QuoteIcon =

    type [<AllowNullLiteral>] IExports =
        abstract QuoteIcon: props: React.ComponentPropsWithoutRef<string> -> JSX.Element

module __Box_Box =
    type DefaultProps = __Box_@mantine_styles.DefaultProps

    type [<AllowNullLiteral>] IExports =
        abstract _Box: React.ForwardRefExoticComponent<obj>
        abstract Box: obj

    type [<AllowNullLiteral>] BoxProps =
        inherit DefaultProps
        abstract children: React.ReactNode option with get, set

module __Breadcrumbs_Breadcrumbs =
    type DefaultProps = __Breadcrumbs_@mantine_styles.DefaultProps
    type Selectors = __Breadcrumbs_@mantine_styles.Selectors

    type [<AllowNullLiteral>] IExports =
        abstract Breadcrumbs: React.ForwardRefExoticComponent<obj>

    type BreadcrumbsStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] BreadcrumbsProps =
        inherit DefaultProps<BreadcrumbsStylesNames>
        inherit React.ComponentPropsWithoutRef<string>
        /// Separator between breadcrumbs
        abstract separator: React.ReactNode option with get, set
        /// React nodes that should be separated
        abstract children: React.ReactNode with get, set

module __Breadcrumbs_Breadcrumbs_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (unit -> obj -> IExports_default)

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract breadcrumb: string with get, set
        abstract separator: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Burger_Burger =
    type DefaultProps = __Burger_@mantine_styles.DefaultProps
    type MantineNumberSize = __Burger_@mantine_styles.MantineNumberSize
    type Selectors = __Burger_@mantine_styles.Selectors
    type BurgerStylesParams = __Burger_Burger_styles.BurgerStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Burger: React.ForwardRefExoticComponent<obj>

    type BurgerStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] BurgerProps =
        inherit DefaultProps<BurgerStylesNames, BurgerStylesParams>
        inherit React.ComponentPropsWithoutRef<string>
        /// Burger state: true for cross, false for burger
        abstract opened: bool with get, set
        /// Burger color value, not connected to theme.colors, defaults to theme.black with light color scheme and theme.white with dark
        abstract color: string option with get, set
        /// Predefined burger size or number to set width and height in px
        abstract size: MantineNumberSize option with get, set
        /// Transition duration in ms
        abstract transitionDuration: float option with get, set

module __Burger_Burger_styles =
    type MantineNumberSize = __Burger_@mantine_styles.MantineNumberSize
    type MantineColor = __Burger_@mantine_styles.MantineColor

    type [<AllowNullLiteral>] IExports =
        abstract _default: (BurgerStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] BurgerStylesParams =
        abstract size: MantineNumberSize with get, set
        abstract color: MantineColor with get, set
        abstract transitionDuration: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract burger: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Button_Button =
    type DefaultProps = __Button_@mantine_styles.DefaultProps
    type MantineSize = __Button_@mantine_styles.MantineSize
    type MantineNumberSize = __Button_@mantine_styles.MantineNumberSize
    type MantineGradient = __Button_@mantine_styles.MantineGradient
    type MantineColor = __Button_@mantine_styles.MantineColor
    type Selectors = __Button_@mantine_styles.Selectors
    type LoaderProps = Loader.LoaderProps
    type ButtonGroup = __Button_ButtonGroup_ButtonGroup.ButtonGroup
    type ButtonVariant = __Button_Button_styles.ButtonVariant
    type ButtonStylesParams = __Button_Button_styles.ButtonStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract _Button: obj option
        abstract Button: obj

    type ButtonStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] ButtonProps =
        inherit DefaultProps<ButtonStylesNames, ButtonStylesParams>
        /// Predefined button size
        abstract size: MantineSize option with get, set
        /// Button type attribute
        abstract ``type``: ButtonPropsType option with get, set
        /// Button color from theme
        abstract color: MantineColor option with get, set
        /// Adds icon before button label
        abstract leftIcon: React.ReactNode option with get, set
        /// Adds icon after button label
        abstract rightIcon: React.ReactNode option with get, set
        /// Sets button width to 100% of parent element
        abstract fullWidth: bool option with get, set
        /// Button border-radius from theme or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set
        /// Controls button appearance
        abstract variant: ButtonVariant option with get, set
        /// Controls gradient settings in gradient variant only
        abstract gradient: MantineGradient option with get, set
        /// Set text-transform to uppercase
        abstract uppercase: bool option with get, set
        /// Reduces vertical and horizontal spacing
        abstract compact: bool option with get, set
        /// Indicate loading state
        abstract loading: bool option with get, set
        /// Props spread to Loader component
        abstract loaderProps: LoaderProps option with get, set
        /// Loader position relative to button label
        abstract loaderPosition: ButtonPropsLoaderPosition option with get, set
        /// Button label
        abstract children: React.ReactNode option with get, set
        /// Disabled state
        abstract disabled: bool option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ButtonPropsType =
        | Submit
        | Button
        | Reset

    type [<StringEnum>] [<RequireQualifiedAccess>] ButtonPropsLoaderPosition =
        | Left
        | Right
        | Center

module __Button_Button_styles =
    type MantineSize = __Button_@mantine_styles.MantineSize
    type MantineNumberSize = __Button_@mantine_styles.MantineNumberSize
    type MantineColor = __Button_@mantine_styles.MantineColor
    type MantineTheme = __Button_@mantine_styles.MantineTheme
    type MantineGradient = __Button_@mantine_styles.MantineGradient

    type [<AllowNullLiteral>] IExports =
        abstract BUTTON_VARIANTS: string * string * string * string * string * string * string
        abstract sizes: IExportsSizes
        abstract _default: (ButtonStylesParams -> obj -> IExports_default)

    type ButtonVariant =
        obj

    type [<AllowNullLiteral>] ButtonStylesParams =
        abstract color: MantineColor with get, set
        abstract size: MantineSize with get, set
        abstract radius: MantineNumberSize with get, set
        abstract fullWidth: bool with get, set
        abstract compact: bool with get, set
        abstract gradient: MantineGradient with get, set
        abstract variant: ButtonVariant with get, set
        abstract withRightIcon: bool with get, set
        abstract withLeftIcon: bool with get, set

    type [<AllowNullLiteral>] IExportsSizesXs =
        abstract height: float with get, set
        abstract paddingLeft: float with get, set
        abstract paddingRight: float with get, set

    type [<AllowNullLiteral>] IExportsSizes =
        abstract xs: IExportsSizesXs with get, set
        abstract sm: IExportsSizesXs with get, set
        abstract md: IExportsSizesXs with get, set
        abstract lg: IExportsSizesXs with get, set
        abstract xl: IExportsSizesXs with get, set
        abstract ``compact-xs``: IExportsSizesXs with get, set
        abstract ``compact-sm``: IExportsSizesXs with get, set
        abstract ``compact-md``: IExportsSizesXs with get, set
        abstract ``compact-lg``: IExportsSizesXs with get, set
        abstract ``compact-xl``: IExportsSizesXs with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract icon: string with get, set
        abstract leftIcon: string with get, set
        abstract rightIcon: string with get, set
        abstract centerLoader: string with get, set
        abstract inner: string with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Card_Card_context =

    type [<AllowNullLiteral>] IExports =
        abstract CardProvider: obj
        abstract useCardPadding: (unit -> U2<string, float>)

module __Card_Card =
    type MantineNumberSize = __Card_@mantine_styles.MantineNumberSize
    type PaperProps = __Paper_Paper.PaperProps
    type CardSection = __Card_CardSection_CardSection.CardSection

    type [<AllowNullLiteral>] IExports =
        abstract _Card: obj option
        abstract Card: obj

    type [<AllowNullLiteral>] CardProps =
        inherit Omit<PaperProps, string>
        abstract p: MantineNumberSize option with get, set
        /// Card content
        abstract children: React.ReactNode with get, set

module __Card_Card_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (unit -> obj -> IExports_default)

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Center_Center =
    type DefaultProps = __Center_@mantine_styles.DefaultProps

    type [<AllowNullLiteral>] IExports =
        abstract _Center: React.ForwardRefExoticComponent<obj>
        abstract Center: obj

    type [<AllowNullLiteral>] CenterProps =
        inherit DefaultProps
        /// Content that should be centered vertically and horizontally
        abstract children: React.ReactNode with get, set
        /// Set to true to use inline-flex instead of flex
        abstract ``inline``: bool option with get, set

module __Checkbox_Checkbox =
    type DefaultProps = __Checkbox_@mantine_styles.DefaultProps
    type MantineSize = __Checkbox_@mantine_styles.MantineSize
    type MantineColor = __Checkbox_@mantine_styles.MantineColor
    type Selectors = __Checkbox_@mantine_styles.Selectors
    type MantineNumberSize = __Checkbox_@mantine_styles.MantineNumberSize
    type ForwardRefWithStaticComponents = __Checkbox_@mantine_utils.ForwardRefWithStaticComponents
    type InlineInputStylesNames = InlineInput.InlineInputStylesNames
    type CheckboxGroup = __Checkbox_CheckboxGroup_CheckboxGroup.CheckboxGroup
    type CheckboxStylesParams = __Checkbox_Checkbox_styles.CheckboxStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Checkbox: CheckboxComponent

    type CheckboxStylesNames =
        U2<Selectors<obj>, InlineInputStylesNames>

    type [<AllowNullLiteral>] CheckboxProps =
        inherit DefaultProps<CheckboxStylesNames, CheckboxStylesParams>
        inherit Omit<React.ComponentPropsWithRef<string>, CheckboxPropsOmit>
        /// Key of theme.colors
        abstract color: MantineColor option with get, set
        /// Key of theme.radius or number to set border-radius in px
        abstract radius: MantineNumberSize option with get, set
        /// Predefined label font-size and checkbox width and height in px
        abstract size: MantineSize option with get, set
        /// Checkbox label
        abstract label: React.ReactNode option with get, set
        /// Indeterminate state of checkbox, overwrites checked
        abstract indeterminate: bool option with get, set
        /// Props spread to wrapper element
        abstract wrapperProps: Record<string, obj option> option with get, set
        /// id to connect label with input
        abstract id: string option with get, set
        /// Transition duration in ms
        abstract transitionDuration: float option with get, set
        /// Icon rendered when checkbox has checked or indeterminate state
        abstract icon: React.FC<CheckboxPropsIconReactFC> option with get, set
        /// Position of label
        abstract labelPosition: CheckboxPropsLabelPosition option with get, set
        /// description, displayed after label
        abstract description: React.ReactNode option with get, set
        /// Displays error message after input
        abstract error: React.ReactNode option with get, set

    type CheckboxComponent =
        ForwardRefWithStaticComponents<CheckboxProps, CheckboxComponentForwardRefWithStaticComponents>

    type [<StringEnum>] [<RequireQualifiedAccess>] CheckboxPropsOmit =
        | Type
        | Size

    type [<AllowNullLiteral>] CheckboxPropsIconReactFC =
        abstract indeterminate: bool with get, set
        abstract className: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] CheckboxPropsLabelPosition =
        | Left
        | Right

    type [<AllowNullLiteral>] CheckboxComponentForwardRefWithStaticComponents =
        abstract Group: obj with get, set

module __Checkbox_Checkbox_styles =
    type MantineSize = __Checkbox_@mantine_styles.MantineSize
    type MantineColor = __Checkbox_@mantine_styles.MantineColor
    type MantineNumberSize = __Checkbox_@mantine_styles.MantineNumberSize

    type [<AllowNullLiteral>] IExports =
        abstract _default: (CheckboxStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] CheckboxStylesParams =
        abstract size: MantineSize with get, set
        abstract radius: MantineNumberSize with get, set
        abstract color: MantineColor with get, set
        abstract transitionDuration: float with get, set
        abstract labelPosition: CheckboxStylesParamsLabelPosition with get, set
        abstract error: bool with get, set
        abstract indeterminate: bool with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract icon: string with get, set
        abstract inner: string with get, set
        abstract input: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] CheckboxStylesParamsLabelPosition =
        | Left
        | Right

module __Checkbox_CheckboxGroup_context =
    type MantineSize = __Checkbox_@mantine_styles.MantineSize

    type [<AllowNullLiteral>] IExports =
        abstract CheckboxGroupProvider: obj
        abstract useCheckboxGroupContext: (unit -> CheckboxGroupContextValue)

    type [<AllowNullLiteral>] CheckboxGroupContextValue =
        abstract value: ResizeArray<string> with get, set
        abstract onChange: ``event``: React.ChangeEvent<HTMLInputElement> -> unit
        abstract size: MantineSize with get, set

module __Checkbox_CheckboxIcon =

    type [<AllowNullLiteral>] IExports =
        abstract CheckIcon: props: React.ComponentPropsWithoutRef<string> -> JSX.Element
        abstract CheckboxIcon: p0: CheckboxIconProps -> JSX.Element

    type [<AllowNullLiteral>] CheckboxIconProps =
        inherit React.ComponentPropsWithoutRef<string>
        abstract indeterminate: bool with get, set

module __Chip_Chip =
    type DefaultProps = __Chip_@mantine_styles.DefaultProps
    type MantineNumberSize = __Chip_@mantine_styles.MantineNumberSize
    type MantineSize = __Chip_@mantine_styles.MantineSize
    type MantineColor = __Chip_@mantine_styles.MantineColor
    type Selectors = __Chip_@mantine_styles.Selectors
    type ForwardRefWithStaticComponents = __Chip_@mantine_utils.ForwardRefWithStaticComponents
    type ChipGroup = __Chip_ChipGroup_ChipGroup.ChipGroup
    type ChipStylesParams = __Chip_Chip_styles.ChipStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Chip: ChipComponent

    type ChipStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] ChipProps =
        inherit DefaultProps<ChipStylesNames, ChipStylesParams>
        inherit Omit<React.ComponentPropsWithRef<string>, ChipPropsOmit>
        /// Chip radius from theme or number to set value in px
        abstract radius: MantineNumberSize option with get, set
        /// Predefined chip size
        abstract size: MantineSize option with get, set
        /// Chip input type
        abstract ``type``: ChipPropsType option with get, set
        /// Controls chip appearance, defaults to filled with dark theme and to outline in light theme
        abstract variant: ChipPropsVariant option with get, set
        /// Chip label
        abstract children: React.ReactNode with get, set
        /// Checked state for controlled component
        abstract ``checked``: bool option with get, set
        /// Default value for uncontrolled component
        abstract defaultChecked: bool option with get, set
        /// Calls when checked state changes
        abstract onChange: ``checked``: bool -> unit
        /// Active color from theme, defaults to theme.primaryColor
        abstract color: MantineColor option with get, set
        /// Static id to bind input with label
        abstract id: string option with get, set
        /// Props spread to wrapper element
        abstract wrapperProps: Record<string, obj option> option with get, set

    type ChipComponent =
        ForwardRefWithStaticComponents<ChipProps, ChipComponentForwardRefWithStaticComponents>

    type [<StringEnum>] [<RequireQualifiedAccess>] ChipPropsOmit =
        | Size
        | OnChange

    type [<StringEnum>] [<RequireQualifiedAccess>] ChipPropsType =
        | Radio
        | Checkbox

    type [<StringEnum>] [<RequireQualifiedAccess>] ChipPropsVariant =
        | Outline
        | Filled

    type [<AllowNullLiteral>] ChipComponentForwardRefWithStaticComponents =
        abstract Group: obj with get, set

module __Chip_Chip_styles =
    type MantineNumberSize = __Chip_@mantine_styles.MantineNumberSize
    type MantineSize = __Chip_@mantine_styles.MantineSize
    type MantineColor = __Chip_@mantine_styles.MantineColor

    type [<AllowNullLiteral>] IExports =
        abstract sizes: IExportsSizes
        abstract _default: (ChipStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] ChipStylesParams =
        abstract radius: MantineNumberSize with get, set
        abstract size: MantineSize with get, set
        abstract color: MantineColor with get, set

    type [<AllowNullLiteral>] IExportsSizes =
        abstract xs: float with get, set
        abstract sm: float with get, set
        abstract md: float with get, set
        abstract lg: float with get, set
        abstract xl: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract label: string with get, set
        abstract iconWrapper: string with get, set
        abstract checkIcon: string with get, set
        abstract input: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Chip_ChipGroup_context =

    type [<AllowNullLiteral>] IExports =
        abstract ChipGroupProvider: React.Provider<ChipGroupContextValue>
        abstract useChipGroup: (unit -> ChipGroupContextValue)

    type [<AllowNullLiteral>] ChipGroupContextValue =
        abstract isChipSelected: value: string -> bool
        abstract onChange: ``event``: React.ChangeEvent<HTMLInputElement> -> unit
        abstract multiple: bool with get, set

module __CloseButton_CloseButton =
    type ActionIconProps = __ActionIcon_ActionIcon.ActionIconProps

    type [<AllowNullLiteral>] IExports =
        abstract _CloseButton: React.ForwardRefExoticComponent<obj>
        abstract CloseButton: obj

    type [<AllowNullLiteral>] CloseButtonProps =
        inherit Omit<ActionIconProps, string>
        inherit Omit<React.ComponentPropsWithoutRef<string>, string>
        /// Width and height of cross icon
        abstract iconSize: float option with get, set

module __CloseButton_CloseIcon =

    type [<AllowNullLiteral>] IExports =
        abstract CloseIcon: props: React.ComponentPropsWithoutRef<string> -> JSX.Element

    module CloseIcon =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

module __Code_Code =
    type DefaultProps = __Code_@mantine_styles.DefaultProps
    type MantineColor = __Code_@mantine_styles.MantineColor
    type CodeStylesParams = __Code_Code_styles.CodeStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Code: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] CodeProps =
        inherit DefaultProps<obj, CodeStylesParams>
        inherit React.ComponentPropsWithoutRef<string>
        /// Code content
        abstract children: React.ReactNode with get, set
        /// Code color and background from theme, defaults to gray in light theme and to dark in dark theme
        abstract color: MantineColor option with get, set
        /// True for code block, false for inline code
        abstract block: bool option with get, set

module __Code_Code_styles =
    type MantineColor = __Code_@mantine_styles.MantineColor

    type [<AllowNullLiteral>] IExports =
        abstract _default: (CodeStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] CodeStylesParams =
        abstract color: MantineColor with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract block: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Collapse_Collapse =
    type DefaultProps = __Collapse_@mantine_styles.DefaultProps

    type [<AllowNullLiteral>] IExports =
        abstract Collapse: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] CollapseProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// Content that should be collapsed
        abstract children: React.ReactNode with get, set
        /// Opened state
        abstract ``in``: bool with get, set
        /// Called each time transition ends
        abstract onTransitionEnd: (unit -> unit) option with get, set
        /// Transition duration in ms
        abstract transitionDuration: float option with get, set
        /// Transition timing function
        abstract transitionTimingFunction: string option with get, set
        /// Should opacity be animated
        abstract animateOpacity: bool option with get, set

module __Collapse_use_collapse =

    type [<AllowNullLiteral>] IExports =
        abstract getElementHeight: el: U2<React.RefObject<HTMLElement>, IExportsGetElementHeight> -> U2<float, string>
        abstract useCollapse: p0: UseCollapse -> (GetCollapseProps -> Record<string, obj option>)

    type [<AllowNullLiteral>] UseCollapse =
        abstract opened: bool with get, set
        abstract transitionDuration: float option with get, set
        abstract transitionTimingFunction: string option with get, set
        abstract onTransitionEnd: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] GetCollapseProps =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj with get, set
        abstract style: React.CSSProperties option with get, set
        abstract onTransitionEnd: (TransitionEvent -> unit) option with get, set
        abstract refKey: string option with get, set
        abstract ref: U2<React.MutableRefObject<HTMLDivElement>, (HTMLDivElement -> unit)> option with get, set

    type [<AllowNullLiteral>] IExportsGetElementHeightCurrent =
        abstract scrollHeight: float with get, set

    type [<AllowNullLiteral>] IExportsGetElementHeight =
        abstract current: IExportsGetElementHeightCurrent option with get, set

module __ColorInput_ColorInput =
    type DefaultProps = __ColorInput_@mantine_styles.DefaultProps
    type MantineShadow = __ColorInput_@mantine_styles.MantineShadow
    type InputWrapperBaseProps = Input.InputWrapperBaseProps
    type InputWrapperStylesNames = Input.InputWrapperStylesNames
    type InputSharedProps = Input.InputSharedProps
    type InputStylesNames = Input.InputStylesNames
    type PopoverStylesNames = Popover.PopoverStylesNames
    type MantineTransition = Transition.MantineTransition
    type ColorPickerBaseProps = __ColorPicker_ColorPicker.ColorPickerBaseProps
    type ColorPickerStylesNames = __ColorPicker_ColorPicker.ColorPickerStylesNames

    type [<AllowNullLiteral>] IExports =
        abstract ColorInput: React.ForwardRefExoticComponent<obj>

    type ColorInputStylesNames =
        U4<InputWrapperStylesNames, InputStylesNames, ColorPickerStylesNames, PopoverStylesNames>

    type [<AllowNullLiteral>] ColorInputProps =
        inherit InputWrapperBaseProps
        inherit InputSharedProps
        inherit ColorPickerBaseProps
        inherit DefaultProps<ColorInputStylesNames>
        inherit Omit<React.ComponentPropsWithoutRef<string>, ColorInputPropsOmit>
        /// Disallow free input
        abstract disallowInput: bool option with get, set
        /// call onChange with last valid value onBlur
        abstract fixOnBlur: bool option with get, set
        /// Dropdown element z-index
        abstract dropdownZIndex: float option with get, set
        /// Display swatch with color preview on the left side of input
        abstract withPreview: bool option with get, set
        /// Dropdown transition name or object
        abstract transition: MantineTransition option with get, set
        /// Dropdown appear/disappear transition duration in ms
        abstract transitionDuration: float option with get, set
        /// Dropdown transition timing function, defaults to theme.transitionTimingFunction
        abstract transitionTimingFunction: string option with get, set
        /// Whether to render the dropdown in a Portal
        abstract withinPortal: bool option with get, set
        /// Dropdown box-shadow, key of theme.shadows
        abstract shadow: MantineShadow option with get, set
        /// Determines whether eye dropper button should be displayed in the right section, true by default
        abstract withEyeDropper: bool option with get, set
        /// Replaces default eye dropper icon
        abstract eyeDropperIcon: React.ReactNode option with get, set
        /// Determines whether the dropdown should be closed when color swatch is clicked, false by default
        abstract closeOnColorSwatchClick: bool option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ColorInputPropsOmit =
        | Size
        | OnChange
        | DefaultValue
        | Value

module __ColorInput_EyeDropperIcon =

    type [<AllowNullLiteral>] IExports =
        abstract EyeDropperIcon: p0: obj -> JSX.Element

module __ColorPicker_ColorPicker =
    type DefaultProps = __ColorPicker_@mantine_styles.DefaultProps
    type MantineSize = __ColorPicker_@mantine_styles.MantineSize
    type Selectors = __ColorPicker_@mantine_styles.Selectors
    type ColorSliderStylesNames = __ColorPicker_ColorSlider_ColorSlider.ColorSliderStylesNames
    type SaturationStylesNames = __ColorPicker_Saturation_Saturation.SaturationStylesNames
    type SwatchesStylesNames = __ColorPicker_Swatches_Swatches.SwatchesStylesNames
    type ThumbStylesNames = __ColorPicker_Thumb_Thumb.ThumbStylesNames
    type ColorFormat = __ColorPicker_types.ColorFormat

    type [<AllowNullLiteral>] IExports =
        abstract ColorPicker: React.ForwardRefExoticComponent<obj>

    type ColorPickerStylesNames =
        U5<Selectors<obj>, ColorSliderStylesNames, SwatchesStylesNames, SaturationStylesNames, ThumbStylesNames>

    type [<AllowNullLiteral>] ColorPickerBaseProps =
        /// Controlled component value
        abstract value: string option with get, set
        /// Uncontrolled component default value
        abstract defaultValue: string option with get, set
        /// Called when color changes
        abstract onChange: color: string -> unit
        /// Called when user stops dragging thumb or changes value with arrows
        abstract onChangeEnd: color: string -> unit
        /// Color format
        abstract format: ColorFormat option with get, set
        /// Set to false to display swatches only
        abstract withPicker: bool option with get, set
        /// Predefined colors
        abstract swatches: ResizeArray<string> option with get, set
        /// Number of swatches displayed in one row
        abstract swatchesPerRow: float option with get, set
        /// Predefined component size
        abstract size: MantineSize option with get, set

    type [<AllowNullLiteral>] ColorPickerProps =
        inherit DefaultProps<ColorPickerStylesNames>
        inherit ColorPickerBaseProps
        inherit Omit<React.ComponentPropsWithoutRef<string>, ColorPickerPropsOmit>
        /// Force picker to take 100% width of its container
        abstract fullWidth: bool option with get, set
        /// Should interactive elements be focusable
        abstract focusable: bool option with get, set
        /// Static selector base
        abstract __staticSelector: string option with get, set
        /// Saturation slider aria-label
        abstract saturationLabel: string option with get, set
        /// Hue slider aria-label
        abstract hueLabel: string option with get, set
        /// Alpha slider aria-label
        abstract alphaLabel: string option with get, set
        /// Called when color swatch is clicked
        abstract onColorSwatchClick: color: string -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] ColorPickerPropsOmit =
        | OnChange
        | Value
        | DefaultValue

module __ColorPicker_ColorPicker_styles =
    type MantineSize = __ColorPicker_@mantine_styles.MantineSize

    type [<AllowNullLiteral>] IExports =
        abstract sizes: IExportsSizes
        abstract _default: (ColorPickerStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] ColorPickerStylesParams =
        abstract size: MantineSize with get, set
        abstract fullWidth: bool with get, set

    type [<AllowNullLiteral>] IExportsSizes =
        abstract xs: float with get, set
        abstract sm: float with get, set
        abstract md: float with get, set
        abstract lg: float with get, set
        abstract xl: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract preview: string with get, set
        abstract wrapper: string with get, set
        abstract body: string with get, set
        abstract sliders: string with get, set
        abstract slider: string with get, set
        abstract swatch: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __ColorPicker_types =

    type [<StringEnum>] [<RequireQualifiedAccess>] ColorFormat =
        | Hex
        | Hexa
        | Rgba
        | Rgb
        | Hsl
        | Hsla

    type [<AllowNullLiteral>] HsvaColor =
        abstract h: float with get, set
        abstract s: float with get, set
        abstract v: float with get, set
        abstract a: float with get, set

    type [<AllowNullLiteral>] RgbaColor =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float with get, set

module __ColorSwatch_ColorSwatch =
    type DefaultProps = __ColorSwatch_@mantine_styles.DefaultProps
    type MantineNumberSize = __ColorSwatch_@mantine_styles.MantineNumberSize
    type Selectors = __ColorSwatch_@mantine_styles.Selectors
    type ColorSwatchStylesParams = __ColorSwatch_ColorSwatch_styles.ColorSwatchStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract _ColorSwatch: React.ForwardRefExoticComponent<obj>
        abstract ColorSwatch: obj

    type ColorSwatchStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] ColorSwatchProps =
        inherit DefaultProps<ColorSwatchStylesNames, ColorSwatchStylesParams>
        /// Swatch color value in any css valid format (hex, rgb, etc.)
        abstract color: string with get, set
        /// Width, height and border-radius in px
        abstract size: float option with get, set
        /// Swatch border-radius predefined from theme or number for px value
        abstract radius: MantineNumberSize option with get, set
        /// ColorSwatch children
        abstract children: React.ReactNode option with get, set
        /// Determines whether swatch should have inner shadow
        abstract withShadow: bool option with get, set

module __ColorSwatch_ColorSwatch_styles =
    type MantineNumberSize = __ColorSwatch_@mantine_styles.MantineNumberSize

    type [<AllowNullLiteral>] IExports =
        abstract _default: (ColorSwatchStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] ColorSwatchStylesParams =
        abstract radius: MantineNumberSize with get, set
        abstract size: float with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract overlay: string with get, set
        abstract children: string with get, set
        abstract shadowOverlay: string with get, set
        abstract alphaOverlay: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Container_Container =
    type DefaultProps = __Container_@mantine_styles.DefaultProps
    type MantineNumberSize = __Container_@mantine_styles.MantineNumberSize
    type MantineSize = __Container_@mantine_styles.MantineSize

    type [<AllowNullLiteral>] IExports =
        abstract Container: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] ContainerProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// Predefined container max-width or number for max-width in px
        abstract size: MantineNumberSize option with get, set
        /// If fluid is set to true, size prop is ignored and Container can expand to 100% of width
        abstract fluid: bool option with get, set
        /// Container sizes
        abstract sizes: Record<MantineSize, float> option with get, set

module __Container_Container_styles =
    type MantineNumberSize = __Container_@mantine_styles.MantineNumberSize
    type MantineSize = __Container_@mantine_styles.MantineSize

    type [<AllowNullLiteral>] IExports =
        abstract _default: (ContainerStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] ContainerStylesParams =
        abstract fluid: bool with get, set
        abstract size: MantineNumberSize with get, set
        abstract sizes: Record<MantineSize, float> with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __CopyButton_CopyButton =

    type [<AllowNullLiteral>] IExports =
        abstract CopyButton: props: CopyButtonProps -> JSX.Element

    type [<AllowNullLiteral>] CopyButtonProps =
        /// Function called with current status
        abstract children: payload: CopyButtonPropsChildrenPayload -> React.ReactNode
        /// Value that should be copied to the clipboard
        abstract value: string with get, set
        /// Copied status timeout in ms
        abstract timeout: float option with get, set

    type [<AllowNullLiteral>] CopyButtonPropsChildrenPayload =
        abstract copied: bool with get, set
        abstract copy: unit -> unit

    module CopyButton =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

module __Dialog_Dialog =
    type DefaultProps = __Dialog_@mantine_styles.DefaultProps
    type Selectors = __Dialog_@mantine_styles.Selectors
    type MantineStyleSystemSize = __Dialog_@mantine_styles.MantineStyleSystemSize
    type MantineTransition = Transition.MantineTransition
    type PaperProps = Paper.PaperProps
    type DialogStylesParams = __Dialog_Dialog_styles.DialogStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract DialogBody: props: DialogProps -> JSX.Element
        abstract Dialog: React.ForwardRefExoticComponent<obj>

    type DialogStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] DialogProps =
        inherit Omit<DefaultProps<DialogStylesNames, DialogStylesParams>, MantineStyleSystemSize>
        inherit Omit<PaperProps, DialogPropsOmit>
        /// Display close button at the top right corner
        abstract withCloseButton: bool option with get, set
        /// Called when close button is clicked
        abstract onClose: unit -> unit
        /// Dialog position (fixed in viewport)
        abstract position: DialogPropsPosition option with get, set
        /// Dialog content
        abstract children: React.ReactNode option with get, set
        /// Dialog container z-index
        abstract zIndex: React.CSSProperties option with get, set
        /// Opened state
        abstract opened: bool with get, set
        /// Appear/disappear transition
        abstract transition: MantineTransition option with get, set
        /// Duration in ms of modal transitions, set to 0 to disable all animations
        abstract transitionDuration: float option with get, set
        /// Transition timing function, defaults to theme.transitionTimingFunction
        abstract transitionTimingFunction: string option with get, set
        /// Predefined dialog width or number to set width in px
        abstract size: U2<string, float> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] DialogPropsOmit =
        | ClassNames
        | Styles

    type [<AllowNullLiteral>] DialogPropsPosition =
        abstract top: U2<string, float> option with get, set
        abstract left: U2<string, float> option with get, set
        abstract bottom: U2<string, float> option with get, set
        abstract right: U2<string, float> option with get, set

module __Dialog_Dialog_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (DialogStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] DialogStylesParams =
        abstract size: U2<string, float> with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract closeButton: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Divider_Divider =
    type DefaultProps = __Divider_@mantine_styles.DefaultProps
    type MantineNumberSize = __Divider_@mantine_styles.MantineNumberSize
    type MantineColor = __Divider_@mantine_styles.MantineColor

    type [<AllowNullLiteral>] IExports =
        abstract Divider: React.ForwardRefExoticComponent<obj>

    type DividerStylesNames =
        string

    type [<AllowNullLiteral>] DividerProps =
        inherit DefaultProps<DividerStylesNames>
        inherit React.ComponentPropsWithoutRef<string>
        /// Line color from theme, defaults to gray in light color scheme and to dark in dark color scheme
        abstract color: MantineColor option with get, set
        /// Line orientation
        abstract orientation: DividerPropsOrientation option with get, set
        /// Sets height in horizontal orientation and width in vertical
        abstract size: MantineNumberSize option with get, set
        /// Adds text after line in horizontal orientation
        abstract label: React.ReactNode option with get, set
        /// Label position
        abstract labelPosition: DividerPropsLabelPosition option with get, set
        /// Props spread to Text component in label
        abstract labelProps: Record<string, obj option> option with get, set
        /// Divider borderStyle
        abstract variant: DividerPropsVariant option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] DividerPropsOrientation =
        | Horizontal
        | Vertical

    type [<StringEnum>] [<RequireQualifiedAccess>] DividerPropsLabelPosition =
        | Left
        | Center
        | Right

    type [<StringEnum>] [<RequireQualifiedAccess>] DividerPropsVariant =
        | Solid
        | Dashed
        | Dotted

module __Divider_Divider_styles =
    type MantineNumberSize = __Divider_@mantine_styles.MantineNumberSize
    type MantineColor = __Divider_@mantine_styles.MantineColor
    type MantineTheme = __Divider_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (DividerStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] DividerStylesParams =
        abstract size: MantineNumberSize with get, set
        abstract variant: DividerStylesParamsVariant with get, set
        abstract color: MantineColor with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set
        abstract withLabel: string with get, set
        abstract left: string with get, set
        abstract right: string with get, set
        abstract label: string with get, set
        abstract labelDefaultStyles: string with get, set
        abstract horizontal: string with get, set
        abstract vertical: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] DividerStylesParamsVariant =
        | Solid
        | Dashed
        | Dotted

module __Drawer_Drawer =
    type DefaultProps = __Drawer_@mantine_styles.DefaultProps
    type MantineNumberSize = __Drawer_@mantine_styles.MantineNumberSize
    type MantineShadow = __Drawer_@mantine_styles.MantineShadow
    type Selectors = __Drawer_@mantine_styles.Selectors
    type MantineStyleSystemSize = __Drawer_@mantine_styles.MantineStyleSystemSize
    type MantineTransition = Transition.MantineTransition
    type DrawerPosition = __Drawer_Drawer_styles.DrawerPosition

    type [<AllowNullLiteral>] IExports =
        abstract Drawer: props: DrawerProps -> JSX.Element

    type DrawerStylesNames =
        Exclude<Selectors<obj>, string>

    type [<AllowNullLiteral>] DrawerProps =
        inherit Omit<DefaultProps<DrawerStylesNames>, MantineStyleSystemSize>
        inherit Omit<React.ComponentPropsWithoutRef<string>, string>
        /// If true drawer is mounted to the dom
        abstract opened: bool with get, set
        /// Called when drawer is closed (Escape key and click outside, depending on options)
        abstract onClose: unit -> unit
        /// Drawer body position
        abstract position: DrawerPosition option with get, set
        /// Drawer body width (right | left position) or height (top | bottom position), cannot exceed 100vh for height and 100% for width
        abstract size: U2<string, float> option with get, set
        /// Drawer body shadow from theme or any css shadow value
        abstract shadow: MantineShadow option with get, set
        /// Drawer body padding from theme or number for padding in px
        abstract padding: MantineNumberSize option with get, set
        /// Drawer z-index property
        abstract zIndex: React.CSSProperties option with get, set
        /// Disables focus trap
        abstract trapFocus: bool option with get, set
        /// Disables scroll lock
        abstract lockScroll: bool option with get, set
        /// Disable onMouseDown trigger for outside events
        abstract closeOnClickOutside: bool option with get, set
        /// Disable onKeyDownCapture trigger for escape key press
        abstract closeOnEscape: bool option with get, set
        /// Drawer appear and disappear transition, see Transition component for full documentation
        abstract transition: MantineTransition option with get, set
        /// Transition duration in ms
        abstract transitionDuration: float option with get, set
        /// Drawer transitionTimingFunction css property
        abstract transitionTimingFunction: string option with get, set
        /// Removes overlay entirely
        abstract withOverlay: bool option with get, set
        /// Overlay opacity, number from 0 to 1
        abstract overlayOpacity: float option with get, set
        /// Overlay color, for example, #000
        abstract overlayColor: string option with get, set
        /// Overlay blur in px
        abstract overlayBlur: float option with get, set
        /// Drawer title, displayed in header before close button
        abstract title: React.ReactNode option with get, set
        /// Hides close button if set to false, drawer still can be closed with escape key and by clicking outside
        abstract withCloseButton: bool option with get, set
        /// Close button aria-label
        abstract closeButtonLabel: string option with get, set
        /// id base, used to generate ids to connect drawer title and body with aria- attributes, defaults to random id
        abstract id: string option with get, set
        /// Target element or selector where drawer portal should be rendered
        abstract target: U2<HTMLElement, string> option with get, set
        /// Determines whether drawer should be rendered within Portal, defaults to true
        abstract withinPortal: bool option with get, set
        /// Determines whether focus should be returned to the last active element when drawer is closed
        abstract withFocusReturn: bool option with get, set

    module Drawer =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

module __Drawer_Drawer_styles =
    type MantineTheme = __Drawer_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (DrawerStylesParams -> obj -> IExports_default)

    type [<StringEnum>] [<RequireQualifiedAccess>] DrawerPosition =
        | Top
        | Bottom
        | Left
        | Right

    type [<AllowNullLiteral>] DrawerStylesParams =
        abstract position: DrawerPosition with get, set
        abstract size: U2<float, string> with get, set
        abstract zIndex: React.CSSProperties with get, set
        abstract withOverlay: bool with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract closeButton: string with get, set
        abstract overlay: string with get, set
        abstract body: string with get, set
        abstract root: string with get, set
        abstract drawer: string with get, set
        abstract title: string with get, set
        abstract header: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __FileButton_FileButton =

    type [<AllowNullLiteral>] IExports =
        abstract FileButton: FileButtonComponent

    type FileButtonProps =
        FileButtonProps<obj>

    type [<AllowNullLiteral>] FileButtonProps<'Multiple> =
        /// Called when files are picked
        abstract onChange: payload: obj -> unit
        /// Function that receives button props and returns react node that should be rendered
        abstract children: props: FileButtonPropsChildrenProps -> React.ReactNode
        /// Determines whether user can pick more than one file
        abstract multiple: 'Multiple option with get, set
        /// File input accept attribute, for example, "image/png,image/jpeg"
        abstract accept: string option with get, set
        /// Input name attribute
        abstract name: string option with get, set
        /// Input form attribute
        abstract form: string option with get, set
        /// Function that should be called when value changes to null or empty array
        abstract resetRef: React.ForwardedRef<(unit -> unit)> option with get, set
        /// Disables file picker
        abstract disabled: bool option with get, set
        /// Specifies that, optionally, a new file should be captured, and which device should be used to capture that new media of a type defined by the accept attribute.
        abstract capture: U2<bool, string> option with get, set

    type [<AllowNullLiteral>] FileButtonPropsChildrenProps =
        abstract onClick: unit -> unit

    type [<AllowNullLiteral>] FileButtonComponent =
        interface end

module __FileInput_FileInput =
    type DefaultProps = __FileInput_@mantine_styles.DefaultProps
    type MantineSize = __FileInput_@mantine_styles.MantineSize
    type Selectors = __FileInput_@mantine_styles.Selectors
    type InputSharedProps = Input.InputSharedProps
    type InputStylesNames = Input.InputStylesNames
    type InputWrapperBaseProps = Input.InputWrapperBaseProps
    type InputWrapperStylesNames = Input.InputWrapperStylesNames

    type [<AllowNullLiteral>] IExports =
        abstract _FileInput: React.ForwardRefExoticComponent<obj>
        abstract FileInput: FileInputComponent

    type FileInputStylesNames =
        U3<InputStylesNames, InputWrapperStylesNames, Selectors<obj>>

    type FileInputProps =
        FileInputProps<obj>

    type [<AllowNullLiteral>] FileInputProps<'Multiple> =
        inherit DefaultProps<FileInputStylesNames>
        inherit InputSharedProps
        inherit InputWrapperBaseProps
        inherit Omit<React.ComponentPropsWithoutRef<string>, FileInputPropsOmit>
        /// Props passed to root element (InputWrapper component)
        abstract wrapperProps: Record<string, obj option> option with get, set
        /// Called when user picks files
        abstract onChange: payload: obj -> unit
        /// Controlled input value
        abstract value: obj option with get, set
        /// Uncontrolled input default value
        abstract defaultValue: obj option with get, set
        /// Input size
        abstract size: MantineSize option with get, set
        /// Determines whether user can pick more than one file
        abstract multiple: 'Multiple option with get, set
        /// File input accept attribute, for example, "image/png,image/jpeg"
        abstract accept: string option with get, set
        /// Input name attribute
        abstract name: string option with get, set
        /// Input form attribute
        abstract form: string option with get, set
        /// Current value renderer
        abstract valueComponent: React.FC<FileInputPropsValueComponentReactFC> option with get, set
        /// Allow to clear value
        abstract clearable: bool option with get, set
        /// aria-label for clear button
        abstract clearButtonLabel: string option with get, set
        /// Set the clear button tab index to disabled or default after input field
        abstract clearButtonTabIndex: FileInputPropsClearButtonTabIndex option with get, set
        /// Determines whether the user can change value
        abstract readOnly: bool option with get, set
        /// Specifies that, optionally, a new file should be captured, and which device should be used to capture that new media of a type defined by the accept attribute.
        abstract capture: U2<bool, string> option with get, set

    type [<AllowNullLiteral>] FileInputComponent =
        [<Emit "$0($1...)">] abstract Invoke: props: obj -> JSX.Element

    type [<StringEnum>] [<RequireQualifiedAccess>] FileInputPropsOmit =
        | Size
        | OnChange
        | Value
        | DefaultValue

    type [<AllowNullLiteral>] FileInputPropsValueComponentReactFC =
        abstract value: U2<File, ResizeArray<File>> option with get, set

    type [<RequireQualifiedAccess>] FileInputPropsClearButtonTabIndex =
        | N0 = 0

module __FileInput_FileInput_styles =

    type [<AllowNullLiteral>] IExports =
        abstract _default: (unit -> obj -> IExports_default)

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract placeholder: string with get, set
        abstract input: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Flex_flex_props =

    type [<AllowNullLiteral>] IExports =
        abstract FLEX_SYSTEM_PROPS: Record<string, SystemPropData>

module __Flex_Flex =
    type CSSProperties = React.CSSProperties
    type DefaultProps = __Flex_@mantine_styles.DefaultProps
    type SystemProp = __Flex_@mantine_styles.SystemProp
    type SpacingValue = __Flex_@mantine_styles.SpacingValue

    type [<AllowNullLiteral>] IExports =
        abstract Flex: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] FlexProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// gap CSS property
        abstract gap: SystemProp<SpacingValue> option with get, set
        /// row-gap CSS property
        abstract rowGap: SystemProp<SpacingValue> option with get, set
        /// column-gap CSS property
        abstract columnGap: SystemProp<SpacingValue> option with get, set
        /// align-items CSS property
        abstract align: SystemProp<CSSProperties> option with get, set
        /// justify-content CSS property
        abstract justify: SystemProp<CSSProperties> option with get, set
        /// flex-wrap CSS property
        abstract wrap: SystemProp<CSSProperties> option with get, set
        /// flex-direction CSS property
        abstract direction: SystemProp<CSSProperties> option with get, set

module __Floating_types =

    type [<StringEnum>] [<RequireQualifiedAccess>] FloatingPlacement =
        | End
        | Start

    type [<StringEnum>] [<RequireQualifiedAccess>] FloatingSide =
        | Top
        | Right
        | Bottom
        | Left

    type FloatingPosition =
        U2<FloatingSide, >

    type [<StringEnum>] [<RequireQualifiedAccess>] ArrowPosition =
        | Center
        | Side

module __Floating_use_delayed_hover =

    type [<AllowNullLiteral>] IExports =
        abstract useDelayedHover: p0: UseDelayedHoverInput -> UseDelayedHoverReturn

    type [<AllowNullLiteral>] UseDelayedHoverReturn =
        abstract openDropdown: (unit -> unit) with get, set
        abstract closeDropdown: (unit -> unit) with get, set

    type [<AllowNullLiteral>] UseDelayedHoverInput =
        abstract ``open``: unit -> unit
        abstract close: unit -> unit
        abstract openDelay: float with get, set
        abstract closeDelay: float with get, set

module __Floating_use_floating_auto_update =

    type [<AllowNullLiteral>] IExports =
        abstract useFloatingAutoUpdate: p0: Payload -> unit

    type [<AllowNullLiteral>] Payload =
        abstract opened: bool with get, set
        abstract floating: PayloadFloating with get, set
        abstract positionDependencies: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] PayloadFloatingRefs =
        abstract floating: React.MutableRefObject<obj option> with get, set
        abstract reference: React.MutableRefObject<obj option> with get, set

    type [<AllowNullLiteral>] PayloadFloating =
        abstract update: unit -> unit
        abstract refs: PayloadFloatingRefs with get, set

module __FocusTrap_FocusTrap =

    type [<AllowNullLiteral>] IExports =
        abstract FocusTrap: p0: FocusTrapProps -> React.ReactElement

    type [<AllowNullLiteral>] FocusTrapProps =
        /// Element at which focus should be trapped, should support ref prop
        abstract children: obj option with get, set
        /// Determines whether focus should be trapped within child element
        abstract active: bool option with get, set
        /// Prop that should be used to access component ref
        abstract refProp: string option with get, set

    module FocusTrap =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string

module __Grid_Grid_context =

    type [<AllowNullLiteral>] IExports =
        abstract GridProvider: (IExportsGridProvider -> JSX.Element)
        abstract useGridContext: (unit -> GridContextValue)

    type [<AllowNullLiteral>] GridContextValue =
        abstract gutter: MantineNumberSize with get, set
        abstract gutterXs: MantineNumberSize with get, set
        abstract gutterSm: MantineNumberSize with get, set
        abstract gutterMd: MantineNumberSize with get, set
        abstract gutterLg: MantineNumberSize with get, set
        abstract gutterXl: MantineNumberSize with get, set
        abstract grow: bool with get, set
        abstract columns: float with get, set

    type [<AllowNullLiteral>] IExportsGridProvider =
        abstract value: GridContextValue with get, set
        abstract children: obj with get, set

module __Grid_Grid =
    type DefaultProps = __Grid_@mantine_styles.DefaultProps
    type MantineNumberSize = __Grid_@mantine_styles.MantineNumberSize
    type ForwardRefWithStaticComponents = __Grid_@mantine_utils.ForwardRefWithStaticComponents
    type Col = __Grid_Col_Col.Col

    type [<AllowNullLiteral>] IExports =
        abstract Grid: GridComponent

    type [<AllowNullLiteral>] GridProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithRef<string>
        /// <Col /> components only
        abstract children: React.ReactNode with get, set
        /// Spacing between columns, key of theme.spacing or number for value in px
        abstract gutter: MantineNumberSize option with get, set
        /// Gutter when screen size is larger than theme.breakpoints.xs
        abstract gutterXs: MantineNumberSize option with get, set
        /// Gutter when screen size is larger than theme.breakpoints.sm
        abstract gutterSm: MantineNumberSize option with get, set
        /// Gutter when screen size is larger than theme.breakpoints.md
        abstract gutterMd: MantineNumberSize option with get, set
        /// Gutter when screen size is larger than theme.breakpoints.lg
        abstract gutterLg: MantineNumberSize option with get, set
        /// Gutter when screen size is larger than theme.breakpoints.xl
        abstract gutterXl: MantineNumberSize option with get, set
        /// Should columns in the last row take 100% of grid width
        abstract grow: bool option with get, set
        /// Set grid justify-content property
        abstract justify: React.CSSProperties option with get, set
        /// Set grid align-content property
        abstract align: React.CSSProperties option with get, set
        /// Amount of columns in each row
        abstract columns: float option with get, set

    type GridComponent =
        ForwardRefWithStaticComponents<GridProps, GridComponentForwardRefWithStaticComponents>

    type [<AllowNullLiteral>] GridComponentForwardRefWithStaticComponents =
        abstract Col: obj with get, set

module __Grid_Grid_styles =
    type MantineNumberSize = __Grid_@mantine_styles.MantineNumberSize
    type MantineTheme = __Grid_@mantine_styles.MantineTheme

    type [<AllowNullLiteral>] IExports =
        abstract _default: (GridStylesParams -> obj -> IExports_default)

    type [<AllowNullLiteral>] GridStylesParams =
        abstract gutter: MantineNumberSize with get, set
        abstract gutterXs: MantineNumberSize with get, set
        abstract gutterSm: MantineNumberSize with get, set
        abstract gutterMd: MantineNumberSize with get, set
        abstract gutterLg: MantineNumberSize with get, set
        abstract gutterXl: MantineNumberSize with get, set
        abstract justify: React.CSSProperties option with get, set
        abstract align: React.CSSProperties option with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: MantineTheme with get, set

module __Group_Group =
    type DefaultProps = __Group_@mantine_styles.DefaultProps
    type MantineNumberSize = __Group_@mantine_styles.MantineNumberSize
    type GroupPosition = __Group_Group_styles.GroupPosition

    type [<AllowNullLiteral>] IExports =
        abstract Group: React.ForwardRefExoticComponent<obj>

    type [<AllowNullLiteral>] GroupProps =
        inherit DefaultProps
        inherit React.ComponentPropsWithoutRef<string>
        /// Defines justify-content property
        abstract position: GroupPosition option with get, set
        /// Defined flex-wrap property
        abstract noWrap: bool option with get, set
        /// Defines flex-grow property for each element, true -> 1, false -> 0
        abstract grow: bool option with get, set
        /// Space between elements
        abstract spacing: MantineNumberSize option with get, set
        /// Defines align-items css property
        abstract align: React.CSSProperties option with get, set

module __Group_Group_styles =
    type MantineNumberSize = __Group_@mantine_styles.MantineNumberSize

    type [<AllowNullLiteral>] IExports =
        abstract GROUP_POSITIONS: IExportsGROUP_POSITIONS
        abstract _default: (GroupStylesParams -> obj -> IExports_default)

    type [<StringEnum>] [<RequireQualifiedAccess>] GroupPosition =
        | Right
        | Center
        | Left
        | Apart

    type [<AllowNullLiteral>] GroupStylesParams =
        abstract position: GroupPosition with get, set
        abstract noWrap: bool with get, set
        abstract grow: bool with get, set
        abstract spacing: MantineNumberSize with get, set
        abstract align: React.CSSProperties with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] IExportsGROUP_POSITIONS =
        abstract left: string with get, set
        abstract center: string with get, set
        abstract right: string with get, set
        abstract apart: string with get, set

    type [<AllowNullLiteral>] IExports_defaultClasses =
        abstract root: string with get, set

    type [<AllowNullLiteral>] IExports_default =
        abstract classes: IExports_defaultClasses with get, set
        abstract cx: (obj option -> string) with get, set
        abstract theme: obj with get, set

module __Highlight_Highlight =
    type MantineColor = __Highlight_@mantine_styles.MantineColor
    type MantineTheme = __Highlight_@mantine_styles.MantineTheme
    type CSSObject = __Highlight_@mantine_styles.CSSObject
    type TextProps = __Text_Text.TextProps

    type [<AllowNullLiteral>] IExports =
        abstract _Highlight: React.ForwardRefExoticComponent<obj>
        abstract Highlight: obj

    type [<AllowNullLiteral>] HighlightProps =
        inherit TextProps
        /// Substring or an array of substrings to highlight in children
        abstract highlight: U2<string, ResizeArray<string>> with get, set
        /// Color from theme that is used for highlighting
        abstract highlightColor: MantineColor option with get, set
        /// Styles applied to highlighted part
        abstract highlightStyles: U2<CSSObject, (MantineTheme -> CSSObject)> option with get, set
        /// Full string part of which will be highlighted
        abstract children: string with get, set

module __HoverCard_HoverCard_context =

    type [<AllowNullLiteral>] IExports =
        abstract HoverCardContextProvider: (IExportsHoverCardContextProvider -> JSX.Element)
        abstract useHoverCardContext: (unit -> HoverCardContext)

    type [<AllowNullLiteral>] HoverCardContext =
        abstract openDropdown: unit -> unit
        abstract closeDropdown: unit -> unit

    type [<AllowNullLiteral>] IExportsHoverCardContextProvider =
        abstract value: HoverCardContext with get, set
        abstract children: obj with get, set

module __HoverCard_HoverCard =
    type PopoverBaseProps = Popover.PopoverBaseProps
    type HoverCardDropdown = __HoverCard_HoverCardDropdown_HoverCardDropdown.HoverCardDropdown

    type [<AllowNullLiteral>] IExports =
        abstract HoverCard: props: HoverCardProps -> JSX.Element

    type [<AllowNullLiteral>] HoverCardProps =
        inherit PopoverBaseProps
        /// HoverCard.Target and HoverCard.Dropdown components
        abstract children: React.ReactNode option with get, set
        /// Initial opened state
        abstract initiallyOpened: bool option with get, set
        /// Called when dropdown is opened
        abstract onOpen: unit -> unit
        /// Called when dropdown is closed
        abstract onClose: unit -> unit
        /// Open delay in ms
        abstract openDelay: float option with get, set
        /// Close delay in ms
        abstract closeDelay: float option with get, set

    module HoverCard =

        type [<AllowNullLiteral>] IExports =
            abstract displayName: string
            abstract Target: React.ForwardRefExoticComponent<obj>
            abstract Dropdown: obj

module __HoverCard_HoverCard_errors =

    type [<AllowNullLiteral>] IExports =
        abstract HOVER_CARD_ERRORS: IExportsHOVER_CARD_ERRORS

    type [<AllowNullLiteral>] IExportsHOVER_CARD_ERRORS =
        abstract context: string with get, set
        abstract children: string with get, set

module __Image_Image =
    type DefaultProps = __Image_@mantine_styles.DefaultProps
    type MantineNumberSize = __Image_@mantine_styles.MantineNumberSize
    type Selectors = __Image_@mantine_styles.Selectors
    type ImageStylesParams = __Image_Image_styles.ImageStylesParams

    type [<AllowNullLiteral>] IExports =
        abstract Image: React.ForwardRefExoticComponent<obj>

    type ImageStylesNames =
        Selectors<obj>

    type [<AllowNullLiteral>] ImageProps =
        inherit DefaultProps<ImageStylesNames, ImageStylesParams>
        inherit Omit<React.ComponentPropsWithoutRef<string>, string>
        /// Image src
        abstract src: string option with get, set
        /// Image alt text, used as title for placeholder if image was not loaded
        abstract alt: string option with get, set
        /// Image object-fit property
        abstract fit: React.CSSProperties option with get, set

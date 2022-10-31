namespace WithLithum.Polite.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BlipColour
{
    White,
    Red,
    /// <summary>
    /// If the blip is enemy, displays as <see cref="Red"/>; if friendly, displays <see cref="Blue"/>; otherwise, displays
    /// <see cref="Green"/>.
    /// </summary>
    GreenAutomatic,
    /// <summary>
    /// If the blip is enemy, dipslays as <see cref="Red"/>; otherwise, displays <see cref="Blue"/>.
    /// </summary>
    BlueAutomatic,
    /// <summary>
    /// If the blip is enemy, displays as <see cref="Red"/>; if friendly, displays <see cref="Blue"/>; otherwise, displays
    /// <see cref="White"/>.
    /// </summary>
    WhiteAutomatic,
    /// <summary>
    /// If the blip is enemy, displays as <see cref="Red"/>; if friendly, displays <see cref="Blue"/>; otherwise, displays
    /// <see cref="Yellow"/>.
    /// </summary>
    YellowAutomatic,
    LightRed,
    Violet,
    Pink,
    LightOrange,
    LightBrown,
    LightGreen,
    /// <summary>
    /// Light blue but darker / teal (#70a8ae).
    /// </summary>
    LightBlueDimmed,
    LightPurple,
    DarkPurple,
    Cyan,
    LightYellow,
    DimmedOrange,
    LightBlue,
    DarkPink,
    /// <summary>
    /// Dark yellow but darker (#8f8d79).
    /// </summary>
    DarkYellowDarker,
    DarkOrange,
    LightGray,
    LightPink,
    LemonGreen,
    ForestGreen,
    ElectricBlue,
    BrightPurple,
    DarkYellow,
    DarkBlue,
    DarkCyan,
    /// <summary>
    /// Brighter light brown (#b89b7b).
    /// </summary>
    LightBrownBrighter,
    SkyBlue,
    LightYellowBrighter,
    LightPinkBrighter,
    LightRedBrighter,
    Beige,
    White2,
    DimmedBlue,
    LightGray2,
    DarkGray,
    PinkRed,
    BrighterBlue,
    LightGreenBrighter,
    LightOrangeBrighter,
    DimmedWhite,
    Gold,
    Orange,
    BrilliantRose,
    /// <summary>
    /// If the blip is friendly, displays as <see cref="Blue"/>; otherwise, displays as <see cref="Red"/>.
    /// </summary>
    RedAutomatic,
    MediumPurple,
    Salmon,
    DarkGreen,
    BlizzardBlue,
    OracleBlue,
    Silver,
    Brown,
    Blue,
    EastBay,
    Red2,
    YellowOrange,
    MulberryPink,
    AltoGray,
    DellyBeanBlue,
    DarkOrangeLighter,
    Mamba,
    /// <summary>
    /// If the blip is enemy, displays as <see cref="Red"/>; if friendly, displays <see cref="Blue"/>; otherwise, displays
    /// <see cref="YellowOrange"/>.
    /// </summary>
    YellowOrangeAutomatic,
    BlueAutomatic2,
    BlueAutomatic3,
    GreenAutomatic2,
    YellowOrange2,
    YellowOrange3,
    BlackTransprent,
    YellowOrange4,
    Blue2,
    Red3,
    DeepRed,
    Blue3,
    OracleBlue2,
    RedTransparent,
    BlueTransparent,
    Orange2,
    LightGreenLightest,
    Purple,
    Blue4,
    BlackTransparent2
}

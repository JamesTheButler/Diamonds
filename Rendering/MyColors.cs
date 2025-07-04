using System.Windows.Media;

namespace DiamondLab.Rendering;

public static class MyColors
{
    public static readonly Color Background = (Color)ColorConverter.ConvertFromString("#ECDFCC");

    public static readonly Color Lightest = (Color)ColorConverter.ConvertFromString("#DFD0B8");
    public static readonly Color Light = (Color)ColorConverter.ConvertFromString("#948979");
    public static readonly Color Dark = (Color)ColorConverter.ConvertFromString("#393E46");
    public static readonly Color Darkest = (Color)ColorConverter.ConvertFromString("#222831");

    public static readonly Color Debug = Colors.Red;
}
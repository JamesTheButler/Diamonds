using System.Windows.Media;

namespace Diamonds.Rendering;

public readonly record struct ColorSettings(
    Color BackgroundColor,
    Color DiamondColor,
    Color CanvasRimColor,
    Color MountingRimColor)
{
    public static ColorSettings Defaults => new(
        BackgroundColor: MyColors.Light,
        DiamondColor: MyColors.Dark,
        CanvasRimColor: Colors.White, 
        MountingRimColor: MyColors.Darkest
    );
}
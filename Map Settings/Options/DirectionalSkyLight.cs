namespace InfiniteForgeConstants.MapSettings.Options;

public class DirectionalSkyLight
{
    public ColorId? TopOverride;
    public ColorId? BottomOverride;
    public ColorId? NorthOverride;
    public ColorId? SouthOverride;
    public ColorId? EastOverride;
    public ColorId? WestOverride;

    public DirectionalSkyLight(ColorId? topOverride = null, ColorId? bottomOverride = null, ColorId? northOverride = null,
        ColorId? southOverride = null, ColorId? eastOverride = null, ColorId? westOverride = null)
    {
        TopOverride = topOverride;
        BottomOverride = bottomOverride;
        NorthOverride = northOverride;
        SouthOverride = southOverride;
        EastOverride = eastOverride;
        WestOverride = westOverride;
    }        
}
namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's directional sky light settings.
/// </summary>
public class DirectionalSkyLight
{
    public ColorId? TopOverride;
    public ColorId? BottomOverride;
    public ColorId? NorthOverride;
    public ColorId? SouthOverride;
    public ColorId? EastOverride;
    public ColorId? WestOverride;

    /// <summary>
    /// Create direction sky light settings from optional parameters.
    /// </summary>
    /// <param name="topOverride"> The color to override the top sky light. </param>
    /// <param name="bottomOverride"> The color to override the bottom sky light. </param>
    /// <param name="northOverride"> The color to override the north sky light. </param>
    /// <param name="southOverride"> The color to override the south sky light. </param>
    /// <param name="eastOverride"> The color to override the east sky light. </param>
    /// <param name="westOverride"> The color to override the west sky light. </param>
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
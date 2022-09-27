namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's volumetric fog settings.
/// </summary>
public class VolumetricFog
{
    public bool? Enabled;
    public float? Density;
    public ColorId? Color;
    public float? NearRange;
    public float? FarRange;

    /// <summary>
    /// Create volumetric fog settings from optional parameters
    /// </summary>
    /// <param name="enabled"> Determines if the fog is enabled. </param>
    /// <param name="density"> The fog density of this map. </param>
    /// <param name="color"> The fog color of this map. </param>
    /// <param name="nearRange"> The fog near range of this map. </param>
    /// <param name="farRange"> The fog far range of this map. </param>
    public VolumetricFog(bool? enabled = null, float? density = null, ColorId? color = null, float? nearRange = null,
        float? farRange = null)
    {
        Enabled = enabled;
        Density = density;
        Color = color;
        NearRange = nearRange;
        FarRange = farRange;
    }
}
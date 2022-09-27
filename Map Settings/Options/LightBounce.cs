namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's light bounce settings.
/// </summary>
public class LightBounce
{
    public float? Intensity;
    public ColorId? TintOverride;

    /// <summary>
    /// Create light bounce settings from optional parameters.
    /// </summary>
    /// <param name="intensity"> The intensity of the light bounce of this map. </param>
    /// <param name="tintOverride"> The color to override light bounce of this map. </param>
    public LightBounce(float? intensity = null, ColorId? tintOverride = null)
    {
        Intensity = intensity;
        TintOverride = tintOverride;
    }
}
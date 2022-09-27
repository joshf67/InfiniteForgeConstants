namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's sky light settings.
/// </summary>
public class SkyLight
{
    public float? Intensity;
    public ColorId? TintOverride;

    /// <summary>
    /// Create sky light options from optional parameters.
    /// </summary>
    /// <param name="intensity"> The intensity of the sky light of this map. </param>
    /// <param name="tintOverride"> The color to override sky light of this map. </param>
    public SkyLight(float? intensity = null, ColorId? tintOverride = null)
    {
        Intensity = intensity;
        TintOverride = tintOverride;
    }
}
namespace InfiniteForgeConstants.MapSettings.Options;

public class SkyLight
{
    public float? Intensity;
    public ColorId? TintOverride;

    public SkyLight(float? intensity = null, ColorId? tintOverride = null)
    {
        Intensity = intensity;
        TintOverride = tintOverride;
    }
}
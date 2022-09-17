namespace InfiniteForgeConstants.MapSettings.Options;

public class LightBounce
{
    public float? Intensity;
    public ColorId? TintOverride;

    public LightBounce(float? intensity = null, ColorId? tintOverride = null)
    {
        Intensity = intensity;
        TintOverride = tintOverride;
    }
}
namespace InfiniteForgeConstants.MapSettings.Options;

public class VolumetricFog
{
    public bool? Enabled;
    public float? Density;
    public ColorId? Color;
    public float? NearRange;
    public float? FarRange;

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
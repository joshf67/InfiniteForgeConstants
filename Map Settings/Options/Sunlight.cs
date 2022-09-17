using System.Numerics;

namespace InfiniteForgeConstants.MapSettings.Options;

public class Sunlight
{
    public float? Intensity;
    public ColorId? ColorOverride;
    public Vector2? Direction;

    public Sunlight(float? intensity = null, ColorId? colorOverride = null, Vector2? direction = null)
    {
        Intensity = intensity;
        ColorOverride = colorOverride;
        Direction = direction;
    }
}
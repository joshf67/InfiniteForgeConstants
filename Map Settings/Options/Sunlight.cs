using System.Numerics;

namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's sunlight settings.
/// </summary>
public class Sunlight
{
    public float? Intensity;
    public ColorId? ColorOverride;
    public Vector2? Direction;

    /// <summary>
    /// Create sunlight settings from optional parameters
    /// </summary>
    /// <param name="intensity"> The sunlight intensity of this map. </param>
    /// <param name="colorOverride"> The sunlight color override of this map. </param>
    /// <param name="direction"> The sunlight direction of this map. </param>
    public Sunlight(float? intensity = null, ColorId? colorOverride = null, Vector2? direction = null)
    {
        Intensity = intensity;
        ColorOverride = colorOverride;
        Direction = direction;
    }
}
using System.Numerics;

namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's wind direction settings.
/// </summary>
public class WindDirection
{
    public Vector3? Direction;
    public float? Speed;

    /// <summary>
    /// Create wind direction settings from optional parameters.
    /// </summary>
    /// <param name="direction"> The wind direction of this map. </param>
    /// <param name="speed"> The wind speed of this map. </param>
    public WindDirection(Vector3? direction = null, float? speed = null)
    {
        Direction = direction;
        Speed = speed;
    }
}
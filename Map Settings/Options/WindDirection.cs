using System.Numerics;

namespace InfiniteForgeConstants.MapSettings.Options;

public class WindDirection
{
    public Vector3? Direction;
    public float? Speed;

    public WindDirection(Vector3? direction = null, float? speed = null)
    {
        Direction = direction;
        Speed = speed;
    }
}
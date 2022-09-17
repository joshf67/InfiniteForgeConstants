using System.Numerics;
using InfiniteForgeConstants.MapSettings.Options;

namespace InfiniteForgeConstants.MapSettings;

public class MapOptions
{
    public Sunlight? Sunlight;
    public LightBounce? LightBounce;
    public SkyLight? SkyLight;
    public DirectionalSkyLight? DirectionalSkyLight;
    public Vector3? WindDirection;

    public MapOptions(Sunlight? sunlight = null, LightBounce? lightBounce = null, SkyLight? skyLight = null,
        DirectionalSkyLight? directionalSkyLight = null, Vector3? windDirection = null)
    {
        Sunlight = sunlight;
        LightBounce = lightBounce;
        SkyLight = skyLight;
        DirectionalSkyLight = directionalSkyLight;
        WindDirection = windDirection;
    }
}
using System.Numerics;
using InfiniteForgeConstants.MapSettings.Options;

namespace InfiniteForgeConstants.MapSettings;

public class MapOptions
{
    public Sunlight? Sunlight;
    public LightBounce? LightBounce;
    public SkyLight? SkyLight;
    public DirectionalSkyLight? DirectionalSkyLight;
    public WindDirection? WindDirection;
    public VolumetricFog? VolumetricFog;
    public SkyRendering? SkyRendering;
    public AtmosphericFog? AtmosphericFog;

    public MapOptions(Sunlight? sunlight = null, LightBounce? lightBounce = null, SkyLight? skyLight = null,
        DirectionalSkyLight? directionalSkyLight = null, WindDirection? windDirection = null,
        VolumetricFog? volumetricFog = null, SkyRendering? skyRendering = null, AtmosphericFog? atmosphericFog = null)
    {
        Sunlight = sunlight;
        LightBounce = lightBounce;
        SkyLight = skyLight;
        DirectionalSkyLight = directionalSkyLight;
        WindDirection = windDirection;
        VolumetricFog = volumetricFog;
        SkyRendering = skyRendering;
        AtmosphericFog = atmosphericFog;
    }
}
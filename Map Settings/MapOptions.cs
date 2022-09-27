// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

using System.Numerics;
using InfiniteForgeConstants.MapSettings.Options;

namespace InfiniteForgeConstants.MapSettings;

/// <summary>
/// Class that contains any data required for a map's visual settings.
/// </summary>
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

    /// <summary>
    /// Create map options using optional parameters.
    /// </summary>
    /// <param name="sunlight"> The sunlight settings of this map. </param>
    /// <param name="lightBounce"> The light bounce settings of this map. </param>
    /// <param name="skyLight"> The sky light settings of this map. </param>
    /// <param name="directionalSkyLight"> The directional sky light settings of this map. </param>
    /// <param name="windDirection"> The wind direction settings of this map. </param>
    /// <param name="volumetricFog"> The volumetric fog settings of this map. </param>
    /// <param name="skyRendering"> The sky rendering settings of this map. </param>
    /// <param name="atmosphericFog"> The atmospheric fog settings of this map. </param>
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
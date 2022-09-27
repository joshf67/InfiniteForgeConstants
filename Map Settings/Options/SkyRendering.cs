namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's sky rendering settings.
/// </summary>
public class SkyRendering
{
	public float? SkyIntensity;
	public float? SunIntensity;
	public ColorId? SkyTint;
	public float? SkyTintIntensity;
	public ColorId? SunTint;
	public float? SunTintIntensity;

	/// <summary>
	/// Create Sky Rendering settings from optional parameters.
	/// </summary>
	/// <param name="skyIntensity"> The sky intensity of this map. </param>
	/// <param name="sunIntensity"> The sun intensity of this map. </param>
	/// <param name="skyTint"> The sky tint color of this map. </param>
	/// <param name="skyTintIntensity"> The sky tint intensity of this map. </param>
	/// <param name="sunTint"> The sun tint color of this map. </param>
	/// <param name="sunTintIntensity"> The sun tint intensity of this map. </param>
	public SkyRendering(float? skyIntensity = null, float? sunIntensity = null, ColorId? skyTint = null,
		float? skyTintIntensity = null, ColorId? sunTint = null, float? sunTintIntensity = null)
	{
		SkyIntensity = skyIntensity;
		SunIntensity = sunIntensity;
		SkyTint = skyTint;
		SkyTintIntensity = skyTintIntensity;
		SunTint = sunTint;
		SunTintIntensity = sunTintIntensity;
	}

}
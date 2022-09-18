namespace InfiniteForgeConstants.MapSettings.Options;

public class SkyRendering
{
	public float? SkyIntensity;
	public float? SunIntensity;
	public ColorId? SkyTint;
	public float? SkyTintIntensity;
	public ColorId? SunTint;
	public float? SunTintIntensity;

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
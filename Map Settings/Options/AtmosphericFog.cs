namespace InfiniteForgeConstants.MapSettings.Options;

public class AtmosphericFog
{
	public float? FogOffset;
	public float? FogNearFallof;
	public float? FogIntensity;
	public float? FogDepthScale;
	public float? FogFallofUp;
	public float? FogFallofDown;
	public float? SkyFogIntensity;
	public float? Inscattering;
	public ColorId? FakeInscatteringTint;

	public AtmosphericFog(float? fogOffset = null, float? fogNearFallof = null, float? fogIntensity = null,
		float? fogDepthScale = null, float? fogFallofUp = null, float? fogFallofDown = null, float? skyFogIntensity = null,
		float? inscattering = null, ColorId? fakeInscatteringTint = null)
	{
		FogOffset = fogOffset;
		FogNearFallof = fogNearFallof;
		FogIntensity = fogIntensity;
		FogDepthScale = fogDepthScale;
		FogFallofUp = fogFallofUp;
		FogFallofDown = fogFallofDown;
		SkyFogIntensity = skyFogIntensity;
		Inscattering = inscattering;
		FakeInscatteringTint = fakeInscatteringTint;
	}
}
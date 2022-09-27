namespace InfiniteForgeConstants.MapSettings.Options;

/// <summary>
/// Class that contains any data required for a map's atmospheric fog settings.
/// </summary>
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

	/// <summary>
	/// Create atmospheric fog settings from optional parameters.
	/// </summary>
	/// <param name="fogOffset"> The atmospheric fog offset of this map. </param>
	/// <param name="fogNearFallof"> The atmospheric fog near fall of of this map. </param>
	/// <param name="fogIntensity"> The atmospheric fog intensity of this map. </param>
	/// <param name="fogDepthScale"> The atmospheric fog depth scale of this map. </param>
	/// <param name="fogFallofUp"> The atmospheric fog fall of up of this map. </param>
	/// <param name="fogFallofDown"> The atmospheric fog fall of down offset of this map. </param>
	/// <param name="skyFogIntensity"> The atmospheric sky fog intensity of this map. </param>
	/// <param name="inscattering"> The atmospheric fog inscattering of this map. </param>
	/// <param name="fakeInscatteringTint"> The atmospheric fog fake inscattering tint of this map. </param>
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
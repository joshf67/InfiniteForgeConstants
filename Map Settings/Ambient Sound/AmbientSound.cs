namespace InfiniteForgeConstants.MapSettings.AmbientSound;

/// <summary>
/// Class that contains any data required for a map's sound settings.
/// </summary>
public class AmbientSound
{
    public PrimarySoundId? PrimarySound;
    public SecondarySoundId? SecondarySound;
    public ReverbId? Reverb;
    public AudioEffectId? AudioEffect;

    public bool? EnablePreview;

    /// <summary>
    /// Create ambient sound with optional parameters
    /// </summary>
    /// <param name="primarySound"> The primary sound of this map. </param>
    /// <param name="secondarySound"> The secondary sound of this map. </param>
    /// <param name="reverb"> The reverb sound of this map. </param>
    /// <param name="audioEffect"> The audio effect of this map. </param>
    /// <param name="enablePreview"> Determines if sound previews should be enabled. </param>
    public AmbientSound(PrimarySoundId? primarySound = null, SecondarySoundId? secondarySound = null,
        ReverbId? reverb = null, AudioEffectId? audioEffect = null, bool? enablePreview = false)
    {
        PrimarySound = primarySound;
        SecondarySound = secondarySound;
        Reverb = reverb;
        AudioEffect = audioEffect;
        EnablePreview = enablePreview;
    }
}
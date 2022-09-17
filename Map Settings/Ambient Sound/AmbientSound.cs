namespace InfiniteForgeConstants.MapSettings.AmbientSound;

public class AmbientSound
{
    public PrimarySoundId? PrimarySound;
    public SecondarySoundId? SecondarySound;
    public ReverbId? Reverb;
    public AudioEffectId? AudioEffect;

    public bool? EnablePreview;

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
namespace InfiniteForgeConstants.MaterialSettings.Grime;

public struct MaterialGrime
{
    public GrimeId GrimeId;
    public float ScratchAmount;
    public float GrimeAmount;

    public MaterialGrime(GrimeId grimeId, float scratchAmount, float grimeAmount)
    {
        GrimeId = grimeId;
        ScratchAmount = scratchAmount;
        GrimeAmount = grimeAmount;
    }
}
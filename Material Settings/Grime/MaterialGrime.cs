namespace InfiniteForgeConstants.MaterialSettings.Grime;

/// <summary>
/// Struct that contains any data required for object's grime.
/// </summary>
public struct MaterialGrime
{
    public GrimeId GrimeId;
    public float ScratchAmount;
    public float GrimeAmount;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="grimeId"> The texture swatch index to use. </param>
    /// <param name="scratchAmount"> The level of scratch for this texture. </param>
    /// <param name="grimeAmount"> The level of grime for this texture. </param>
    public MaterialGrime(GrimeId grimeId, float scratchAmount, float grimeAmount)
    {
        GrimeId = grimeId;
        ScratchAmount = scratchAmount;
        GrimeAmount = grimeAmount;
    }
}
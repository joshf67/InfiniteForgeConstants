using System.Numerics;

namespace InfiniteForgeConstants.MaterialSettings.Region;

/// <summary>
/// Struct that contains any data required for object's materials.
/// </summary>
public struct MaterialRegion
{
    public SwatchId SwatchId;
    public Vector3 SwatchColor;
    public MetalType Metal;
    public float Roughness;
    public float ColorSpread;

    /// <summary>
    /// Constructs a material region to be used when texturing an object.
    /// </summary>
    /// <param name="swatchId"> The texture swatch index to use. </param>
    /// <param name="swatchColor"> The color of this texture. </param>
    /// <param name="metal"> The metallic type of this texture. </param>
    /// <param name="roughness"> The level of roughness for this texture. </param>
    /// <param name="colorSpread"> The level of color spread for this texture. </param>
    public MaterialRegion(SwatchId swatchId, Vector3 swatchColor, MetalType metal, float roughness, float colorSpread)
    {
        SwatchId = swatchId;
        SwatchColor = swatchColor;
        Metal = metal;
        Roughness = roughness;
        ColorSpread = colorSpread;
    }
}
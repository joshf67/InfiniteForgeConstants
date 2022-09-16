using System.Numerics;

namespace InfiniteForgeConstants.MaterialSettings.Region;

public struct MaterialRegion
{
    public SwatchId SwatchId;
    public Vector3 SwatchColor;
    public MetalType Metal;
    public float Roughness;
    public float ColorSpread;

    public MaterialRegion(SwatchId swatchId, Vector3 swatchColor, MetalType metal, float roughness, float colorSpread)
    {
        SwatchId = swatchId;
        SwatchColor = swatchColor;
        Metal = metal;
        Roughness = roughness;
        ColorSpread = colorSpread;
    }
}
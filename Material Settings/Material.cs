// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

using InfiniteForgeConstants.MaterialSettings.Grime;
using InfiniteForgeConstants.MaterialSettings.Region;

namespace InfiniteForgeConstants.MaterialSettings;

/// <summary>
/// Class that contains any data required for object's materials and grime.
/// </summary>
public class Material
{
    public MaterialRegion? Region1;
    public MaterialRegion? Region2;
    public MaterialRegion? Region3;
    public MaterialGrime? Grime;

    /// <summary>
    /// Creates a material from 3 optional regions and an optional grime region.
    /// </summary>
    /// <param name="region1"> The first texture region for this material. </param>
    /// <param name="region2"> The second texture region for this material. </param>
    /// <param name="region3"> The third texture region for this material. </param>
    /// <param name="grime"> The grime texture region for this material. </param>
    public Material(MaterialRegion? region1, MaterialRegion? region2, MaterialRegion? region3, MaterialGrime grime)
    {
        Region1 = region1;
        Region2 = region2;
        Region3 = region3;
        Grime = grime;
    }
}
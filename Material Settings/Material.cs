using InfiniteForgeConstants.MaterialSettings.Grime;
using InfiniteForgeConstants.MaterialSettings.Region;

namespace InfiniteForgeConstants.MaterialSettings;

public class Material
{
    public MaterialRegion? Region1;
    public MaterialRegion? Region2;
    public MaterialRegion? Region3;
    public MaterialGrime? Grime;

    public Material(MaterialRegion? region1, MaterialRegion? region2, MaterialRegion? region3, MaterialGrime grime)
    {
        Region1 = region1;
        Region2 = region2;
        Region3 = region3;
        Grime = grime;
    }
}
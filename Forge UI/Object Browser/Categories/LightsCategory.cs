using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Lights;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class LightsCategory : ForgeUICategory
{
    public LightsCategory(int order) : base("Lights", order)
    {
        AddFolder(new ForerunnerLightFolder());
        AddFolder(new ForerunnerLightMPFolder());
        AddFolder(new ForerunnerNoLightFolder());
        AddFolder(new ForerunnerNoLightMPFolder());
        AddFolder(new GenericLightObjectsFolder());
        AddFolder(new UNSCLightFolder());
        AddFolder(new UNSCLightMPFolder());
        AddFolder(new UNSCNoLightFolder());
        AddFolder(new UNSCNoLightMPFolder());
    }
}
using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.FX;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class FXCategory : ForgeUICategory
{
    public FXCategory(int order) : base("FX", order)
    {
        AddFolder(new AmbientLifeFolder());
        AddFolder(new AtmosphericsFolder());
        AddFolder(new EnergyFolder());
        AddFolder(new ExplosionsFolder());
        AddFolder(new FireFolder());
        AddFolder(new GeneralFolder());
        AddFolder(new HologramsFolder());
        AddFolder(new LiquidsFolder());
        AddFolder(new SmokeFolder());
        AddFolder(new SparksFolder());
    }
}
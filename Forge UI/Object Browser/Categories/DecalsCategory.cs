using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Decals;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class DecalsCategory : ForgeUICategory
{
    public DecalsCategory(int order) : base("Decals", order)
    {
        AddFolder(new BuildingSignageBlockersFolder());
        AddFolder(new LettersFolder());
        AddFolder(new NumberedSymbolsFolder());
        AddFolder(new NumbersFolder());
        AddFolder(new UNSCFolder());
    }
}
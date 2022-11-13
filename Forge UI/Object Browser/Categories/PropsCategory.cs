using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Props;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class PropsCategory : ForgeUICategory
{
    public PropsCategory(int order) : base("Props", order)
    {
        AddFolder(new SportsFolder());
        AddFolder(new SummertimeFolder());
        AddFolder(new ToysFolder());
    }
}
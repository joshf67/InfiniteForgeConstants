using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Blockers;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class BlockersCategory : ForgeUICategory
{
    public BlockersCategory(int order) : base("Blockers", order)
    {
        AddFolder(new OneWayBlockersFolder());
        AddFolder(new PlayerBlockersFolder());
        AddFolder(new ProjectileBlockersFolder());
        AddFolder(new TeamBlockersFolder());
        AddFolder(new VehicleBlockersFolder());
    }
}
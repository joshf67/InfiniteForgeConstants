using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Halo_Design_Set;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class HaloDesignSetCategory : ForgeUICategory
{
    public HaloDesignSetCategory(int order) : base("Halo_Design_Set", order)
    {
        AddFolder(new ColumnsFolder());
        AddFolder(new ColumnsMPFolder());
        AddFolder(new CoverFolder());
        AddFolder(new CoverMPFolder());
        AddFolder(new CratesFolder());
        AddFolder(new CratesMPFolder());
        AddFolder(new DoorwaysFolder());
        AddFolder(new DoorwaysMPFolder());
        AddFolder(new FloorsFolder());
        AddFolder(new FloorsMPFolder());
        AddFolder(new RailingsFolder());
        AddFolder(new RailingsMPFolder());
        AddFolder(new RampsFolder());
        AddFolder(new RampsMPFolder());
        AddFolder(new ScaleObjectsFolder());
        AddFolder(new WallsFolder());
        AddFolder(new WallsMPFolder());
    }
}
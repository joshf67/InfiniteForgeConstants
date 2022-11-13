using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Structures;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class StructuresCategory : ForgeUICategory
{
    public StructuresCategory(int order) : base("Structures", order)
    {
        AddFolder(new BeamsFolder());
        AddFolder(new BridgesFolder());
        AddFolder(new BridgesMPFolder());
        AddFolder(new ColumnsFolder());
        AddFolder(new CoverFolder());
        AddFolder(new DoorsFolder());
        AddFolder(new DoorsMPFolder());
        AddFolder(new FloorsFolder());
        AddFolder(new SlopesFolder());
        AddFolder(new WallsFolder());
    }
}
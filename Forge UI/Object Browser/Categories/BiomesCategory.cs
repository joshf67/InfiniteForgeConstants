using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Biomes;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class BiomesCategory : ForgeUICategory
{
    public BiomesCategory(int order) : base("Biomes", order)
    {
        AddFolder(new BushesFolder());
        AddFolder(new FloraFolder());
        AddFolder(new RocksAlpineFolder());
        AddFolder(new RocksBurntForestFolder());
        AddFolder(new RocksDesertFolder());
        AddFolder(new RocksGlacierFolder());
        AddFolder(new RocksMiscFolder());
        AddFolder(new RocksSpaceFolder());
        AddFolder(new RocksTidalFolder());
        AddFolder(new RocksWetlandFolder());
        AddFolder(new StumpsFolder());
        AddFolder(new TerrainFolder());
        AddFolder(new TreesFolder());
        AddFolder(new TreesLogsFolder());
        AddFolder(new TreesRootsFolder());
    }
}
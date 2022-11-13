using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Primitives;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class PrimitivesCategory : ForgeUICategory
{
    public PrimitivesCategory(int order) : base("Primitives", order)
    {
        AddFolder(new BlocksFolder());
        AddFolder(new ConesFolder());
        AddFolder(new CylindersFolder());
        AddFolder(new PryamidsFolder());
        AddFolder(new RingsFolder());
        AddFolder(new SpheresFolder());
        AddFolder(new TrapezoidsFolder());
        AddFolder(new TrianglesFolder());
    }
}
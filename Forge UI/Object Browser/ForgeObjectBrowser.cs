namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public static class ForgeObjectBrowser
{
    public static Dictionary<string, ForgeUICategory> Categories = new Dictionary<string, ForgeUICategory>()
    {
        { "Recents", new RecentsCategory(1) },
        { "Prefabs", new PrefabsCategory(2) },
        { "Accents", new AccentCategory(3) },
        { "Biomes", new BiomesCategory(4) },
        { "Blockers", new BlockersCategory(5) },
        { "Decals", new DecalsCategory(6) },
        { "FX", new FXCategory(7) },
        { "Gameplay", new GameplayCategory(8) },
        { "Halo_Design_Set", new HaloDesignSetCategory(9) },
        { "Lights", new LightsCategory(10) },
        { "Primitives", new PrimitivesCategory(11) },
        { "Props", new PropsCategory(12) },
        { "Structures", new StructuresCategory(13) }
    };
}
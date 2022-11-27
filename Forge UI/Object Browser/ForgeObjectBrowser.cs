using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

/// <summary>
/// Stores all data related to the forge object browser UI
/// </summary>
public static class ForgeObjectBrowser
{
    public static SortedDictionary<string, ForgeUICategory> Categories = new()
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

    /// <summary>
    /// Find an item within any category using the object name
    /// </summary>
    /// <param name="objectName"> The name of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public static bool FindItem(string objectName, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        foreach (var category in Categories.Values)
        {
            if (category.FindItem(objectName, out forgeObject))
            {
                return true;
            }
        }
        return false;
    }
    
    /// <summary>
    /// Find an item within any category using the object name
    /// </summary>
    /// <param name="id"> The ObjectId of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public static bool FindItem(ObjectId id, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        foreach (var cateogry in Categories.Values)
        {
            if (cateogry.FindItem(id, out forgeObject))
            {
                return true;
            }
        }
        return false;
    }
    
    /// <summary>
    /// Add an item to a the object browser
    /// </summary>
    /// <param name="categoryName"> The cateogry to add the forge UI object to </param>
    /// <param name="folderName"> The folder to add the forge UI object to </param>
    /// <param name="forgeUIObject"> The forge UI Object to add </param>
    /// <exception cref="InvalidOperationException"> Throws if the cateogry doesn't exist </exception>
    public static void AddItem(string categoryName, string folderName, ForgeUIObject forgeUIObject)
    {
        if (!Categories.ContainsKey(categoryName))
            throw new InvalidOperationException($"Cateogry {categoryName} doesn't exist in the Object Browser.");

        Categories[categoryName].AddItem(folderName, forgeUIObject);
    }
}
using System.Numerics;

namespace InfiniteForgeConstants.Forge_UI;

public abstract class ForgeUICategory
{
    public string CategoryName;
    public int CategoryOrder;
    public SortedDictionary<string, ForgeUIFolder> CategoryFolders = new();

    public ForgeUICategory(string categoryName, int categoryOrder)
    {
        CategoryName = categoryName;
        CategoryOrder = categoryOrder;
    }

    public void AddFolder(ForgeUIFolder forgeUIFolder, int folderOrder = -1)
    {
        if (CategoryFolders.ContainsKey(forgeUIFolder.FolderName))
            throw new InvalidOperationException($"Folder {forgeUIFolder.FolderName} already exists inside category.");

        if (folderOrder == -1) folderOrder = CategoryFolders.Count + 1;
        forgeUIFolder.FolderOffset = folderOrder;
        forgeUIFolder.ParentCategory = this;

        CategoryFolders.Add(forgeUIFolder.FolderName, forgeUIFolder);
    }

    public ForgeUIObject AddItem(string folderName, string objectName, Vector3? defaultScale = null, int objectOrder = -1)
    {
        if (!CategoryFolders.ContainsKey(folderName))
            throw new InvalidOperationException($"Folder {folderName} doesn't exist in this category.");

        var folder = CategoryFolders[folderName];
        return folder.AddItem(objectName, defaultScale, objectOrder);
    }

    public void AddItem(string folderName, ForgeUIObject forgeUIObject)
    {
        if (!CategoryFolders.ContainsKey(folderName))
            throw new InvalidOperationException($"Folder {folderName} doesn't exist in this category.");

        var folder = CategoryFolders[folderName];
        folder.AddItem(forgeUIObject);
    }
}
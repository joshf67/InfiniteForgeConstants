using System.Numerics;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants.Forge_UI;

/// <summary>
/// Stores any data related to the forge categories inside the content browser
/// </summary>
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

    /// <summary>
    /// Add an item to a specific folder
    /// </summary>
    /// <param name="forgeUIFolder"> The folder to add the forge UI object to </param>
    /// <param name="folderOrder"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void AddFolder(ForgeUIFolder forgeUIFolder, int folderOrder = -1)
    {
        if (CategoryFolders.ContainsKey(forgeUIFolder.FolderName))
            throw new InvalidOperationException($"Folder {forgeUIFolder.FolderName} already exists inside category.");

        if (folderOrder == -1) folderOrder = CategoryFolders.Count + 1;
        forgeUIFolder.FolderOffset = folderOrder;
        forgeUIFolder.ParentCategory = this;

        CategoryFolders.Add(forgeUIFolder.FolderName, forgeUIFolder);
    }
    
    /// <summary>
    /// Add an item to a specific folder
    /// </summary>
    /// <param name="folderName"> The folder to add the forgeUIObject to </param>
    /// <param name="objectName"> The name of the forgeUIObject to add </param>
    /// <param name="objectId"> The ObjectId of the forgeUIObject to add </param>
    /// <param name="defaultObjectMode"> The default object mode of this forgeUIObject </param>
    /// <param name="defaultScale"> The default scale of this forgeUIObject </param>
    /// <param name="objectOrder"> The order of this forgeUIObject in the content browser UI </param>
    /// <returns> the ForgeUIObject generated </returns>
    /// <exception cref="InvalidOperationException"> Throws if the folder doesn't exist </exception>
    public ForgeUIObject AddItem(string folderName, string objectName, ObjectId objectId,
        ForgeUIObjectModeEnum? defaultObjectMode = ForgeUIObjectModeEnum.STATIC, Vector3? defaultScale = null,
        int objectOrder = -1)
    {
        if (!CategoryFolders.ContainsKey(folderName))
            throw new InvalidOperationException($"Folder {folderName} doesn't exist in this category.");

        return CategoryFolders[folderName].AddItem(objectName, objectId, defaultObjectMode, defaultScale, objectOrder);
    }

    /// <summary>
    /// Add an item to a specific folder
    /// </summary>
    /// <param name="folderName"> The folder to add the forge UI object to </param>
    /// <param name="forgeUIObject"> The forge UI Object to add </param>
    /// <exception cref="InvalidOperationException"> Throws if the folder doesn't exist </exception>
    public void AddItem(string folderName, ForgeUIObject forgeUIObject)
    {
        if (!CategoryFolders.ContainsKey(folderName))
            throw new InvalidOperationException($"Folder {folderName} doesn't exist in this category.");

        var folder = CategoryFolders[folderName];
        folder.AddItem(forgeUIObject);
    }
    
    /// <summary>
    /// Find an item within this category using the object name
    /// </summary>
    /// <param name="objectName"> The name of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public bool FindItem(string objectName, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        foreach (var folder in CategoryFolders.Values)
        {
            if (folder.FindItem(objectName, out forgeObject))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Find an item within this category using the object name
    /// </summary>
    /// <param name="id"> The ObjectId of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public bool FindItem(ObjectId id, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        string objectName = Enum.GetName(typeof(ObjectId), id);
        return objectName != null && FindItem(objectName, out forgeObject);
    }
}
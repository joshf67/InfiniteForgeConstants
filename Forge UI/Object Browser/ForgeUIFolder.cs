using System.Numerics;
using System.Text.Json.Serialization;
using InfiniteForgeConstants.Forge_UI.Object_Properties;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public abstract class ForgeUIFolder
{
    
    [JsonIgnore] public ForgeUICategory? ParentCategory;
    public string FolderName = "";
    public int FolderOffset = -1;
    public SortedDictionary<string, ForgeUIObject> FolderObjects = new();

    public ForgeUIFolder(string folderName, ForgeUICategory? parent = null, int folderOffset = -1)
    {
        ParentCategory = parent;
        FolderName = folderName;
        FolderOffset = folderOffset;
    }

    /// <summary>
    /// Add an item to this folder
    /// </summary>
    /// <param name="objectName"> The name of the forgeUIObject to add </param>
    /// <param name="objectId"> The ObjectId of the forgeUIObject to add </param>
    /// <param name="defaultObjectMode"> The default object mode of this forgeUIObject </param>
    /// <param name="defaultScale"> The default scale of this forgeUIObject </param>
    /// <param name="objectOrder"> The order of this forgeUIObject in the content browser UI </param>
    /// <returns> the ForgeUIObject generated </returns>
    /// <exception cref="InvalidOperationException"> Throws if the folder doesn't exist </exception>
    public ForgeUIObject AddItem(string objectName,ObjectId objectId,
        ForgeUIObjectModeEnum? defaultObjectMode = ForgeUIObjectModeEnum.STATIC,
        Vector3? defaultScale = null, int objectOrder = -1)
    {
        if (FolderObjects.ContainsKey(objectName))
            throw new InvalidOperationException($"Object {objectName} already exists inside folder.");

        if (objectOrder == -1) objectOrder = FolderObjects.Count + 1;

        var ret = new ForgeUIObject(objectName, objectOrder,objectId, defaultObjectMode, defaultScale, this);
        ret.ObjectId = objectId; //todo add this to the ctor of the uiobject
        FolderObjects.Add(objectName, ret);
        return ret;
    }
    
    /// <summary>
    /// Add an item to this folder
    /// </summary>
    /// <param name="forgeUIObject"> The forge UI Object to add </param>
    /// <exception cref="InvalidOperationException"> Throws if the folder doesn't exist </exception>
    public void AddItem(ForgeUIObject forgeUiObject)
    {
        if (FolderObjects.ContainsKey(forgeUiObject.ObjectName))
            throw new InvalidOperationException($"Object {forgeUiObject.ObjectName} already exists inside folder.");

        forgeUiObject.ParentFolder = this;

        FolderObjects.Add(forgeUiObject.ObjectName, forgeUiObject);
    }
    
    /// <summary>
    /// Find an item within this folder using the object name
    /// </summary>
    /// <param name="objectName"> The name of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public bool FindItem(string objectName, out ForgeUIObject? forgeObject)
    {
        return FolderObjects.TryGetValue(objectName, out forgeObject);
    }
    
    /// <summary>
    /// Find an item within this folder using the object name
    /// </summary>
    /// <param name="id"> The ObjectId of the forge UI object </param>
    /// <param name="forgeObject"> The forge UI object that was found </param>
    /// <returns> bool if the object exists </returns>
    public bool FindItem(ObjectId id, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        string objectName = Enum.GetName(typeof(ObjectId), id);
        return objectName != null && FolderObjects.TryGetValue(objectName, out forgeObject);
    }
}
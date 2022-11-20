using System.Numerics;
using System.Text.Json.Serialization;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants.Forge_UI;

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

    public ForgeUIObject AddItem(string objectName,ObjectId objectId, ForgeUIObjectModeEnum? defaultObjectMode = ForgeUIObjectModeEnum.STATIC, Vector3? defaultScale = null, int objectOrder = -1)
    {
        if (FolderObjects.ContainsKey(objectName))
            throw new InvalidOperationException($"Object {objectName} already exists inside folder.");

        if (objectOrder == -1) objectOrder = FolderObjects.Count + 1;

        var ret = new ForgeUIObject(objectName, objectOrder, defaultObjectMode, defaultScale, this);
        ret.ObjectId = objectId; //todo add this to the ctor of the uiobject
        FolderObjects.Add(objectName, ret);
        return ret;
    }

    public void AddItem(ForgeUIObject forgeUiObject)
    {
        if (FolderObjects.ContainsKey(forgeUiObject.ObjectName))
            throw new InvalidOperationException($"Object {forgeUiObject.ObjectName} already exists inside folder.");

        forgeUiObject.ParentFolder = this;

        FolderObjects.Add(forgeUiObject.ObjectName, forgeUiObject);
    }
    
    public bool FindItem(string objectName, out ForgeUIObject? forgeObject)
    {
        return FolderObjects.TryGetValue(objectName, out forgeObject);
    }
    
    public bool FindItem(ObjectId id, out ForgeUIObject? forgeObject)
    {
        forgeObject = null;
        string objectName = Enum.GetName(typeof(ObjectId), id);
        return objectName != null && FolderObjects.TryGetValue(objectName, out forgeObject);
    }
}
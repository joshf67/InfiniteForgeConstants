namespace InfiniteForgeConstants.Forge_UI;

public abstract class ForgeUIFolder
{
    public ForgeUICategory? ParentCategory;
    public string FolderName = "";
    public int FolderOffset = -1;
    public Dictionary<string, ForgeUIObject> FolderObjects;

    public ForgeUIFolder(string folderName, ForgeUICategory? parent = null, int folderOffset = -1)
    {
        ParentCategory = parent;
        FolderName = folderName;
        FolderOffset = folderOffset;
    }

    public ForgeUIObject AddItem(string objectName, int objectOrder = -1)
    {
        if (FolderObjects.ContainsKey(objectName))
            throw new InvalidOperationException($"Object {objectName} already exists inside folder.");

        if (objectOrder == -1) objectOrder = FolderObjects.Count + 1;
        
        var ret = new ForgeUIObject(objectName, objectOrder, this);
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
}
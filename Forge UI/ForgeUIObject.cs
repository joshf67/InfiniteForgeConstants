namespace InfiniteForgeConstants.Forge_UI;

public class ForgeUIObject
{
    public ForgeUIFolder ParentFolder;
    public string ObjectName;
    public int ObjectOrder;

    public ForgeUIObject(string objectName, int objectOrder, ForgeUIFolder? parent = null)
    {
        ParentFolder = parent;
        ObjectName = objectName;
        ObjectOrder = objectOrder;
    }
}
using System.Numerics;
using System.Text.Json.Serialization;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants.Forge_UI;

public class ForgeUIObject
{
    [JsonIgnore] public ForgeUIFolder ParentFolder;
    public string ObjectName;
    public int ObjectOrder;
    public Vector3 DefaultScale;
    public ForgeUIObjectModeEnum DefaultObjectMode;
    public ObjectId ObjectId;

    public ForgeUIObject(string objectName, int objectOrder, ObjectId objectId,
        ForgeUIObjectModeEnum? defaultObjectMode = ForgeUIObjectModeEnum.NONE, Vector3? defaultScale = null,
        ForgeUIFolder? parent = null)
    {
        ParentFolder = parent;
        ObjectName = objectName;
        ObjectOrder = objectOrder;
        DefaultScale = defaultScale ?? Vector3.Zero;
        DefaultObjectMode = defaultObjectMode ?? ForgeUIObjectModeEnum.NONE;
    }
}
using System.Numerics;
using System.Text.Json.Serialization;

namespace InfiniteForgeConstants.Forge_UI;

public class ForgeUIObject
{
    [JsonIgnore]
    public ForgeUIFolder ParentFolder;
    public string ObjectName;
    public int ObjectOrder;
    public Vector3 DefaultScale;
    public ForgeUIObjectModeEnum DefaultObjectMode;

    public ForgeUIObject(string objectName, int objectOrder, ForgeUIObjectModeEnum? defaultObjectMode = ForgeUIObjectModeEnum.STATIC, Vector3? defaultScale = null, ForgeUIFolder? parent = null)
    {
        ParentFolder = parent;
        ObjectName = objectName;
        ObjectOrder = objectOrder;
        DefaultScale = defaultScale ?? Vector3.One;
        DefaultObjectMode = defaultObjectMode ?? ForgeUIObjectModeEnum.STATIC;
    }
}
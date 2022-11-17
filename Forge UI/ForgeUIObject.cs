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

    public ForgeUIObject(string objectName, int objectOrder, Vector3? defaultScale = null, ForgeUIFolder? parent = null)
    {
        ParentFolder = parent;
        ObjectName = objectName;
        ObjectOrder = objectOrder;
        DefaultScale = defaultScale ?? Vector3.One;
    }
}
using InfiniteForgeConstants.MaterialSettings;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants;

public class GameObject
{
    public string Name;
    public ObjectId ObjectId;

    public Transform Transform { get; }
    public Material? Material;
    public AdditonalObjectSettings? ObjectSettings;

    public GameObject(string? name, Transform? transform, ObjectId? objectId, AdditonalObjectSettings? objectSettings, Material? material)
    {
        Name = name ?? "Object";
        Transform = transform ?? new Transform();
        ObjectId = objectId ?? ObjectId.PRIMITIVE_BLOCK;
        ObjectSettings = objectSettings;
        Material = material;
    }

    public GameObject()
    {
        Name = "Object";
        Transform = new Transform();
        ObjectId = ObjectId.PRIMITIVE_BLOCK;
    }

}
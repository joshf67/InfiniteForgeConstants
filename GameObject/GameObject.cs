using InfiniteForgeConstants.MaterialSettings;

namespace InfiniteForgeConstants.ObjectSettings;

public class GameObject
{
    public string Name;
    public ObjectId ObjectId;

    public Transform Transform { get; }
    public Material? Material;
    public AdditonalObjectSettings? ObjectSettings;

    public GameObject(string? name = "Object", ObjectId? objectId = ObjectId.PRIMITIVE_BLOCK, Transform? transform = null, AdditonalObjectSettings? objectSettings = null, Material? material = null)
    {
        Name = name ?? "Object";
        ObjectId = objectId ?? ObjectId.PRIMITIVE_BLOCK;
        Transform = transform ?? new Transform();
        ObjectSettings = objectSettings;
        Material = material;
    }

}
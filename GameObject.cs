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

    public GameObject(string? name = "Object", Transform? transform = null, ObjectId? objectId = ObjectId.PRIMITIVE_BLOCK, AdditonalObjectSettings? objectSettings = null, Material? material = null)
    {
        Name = name ?? "Object";
        Transform = transform ?? new Transform();
        ObjectId = objectId ?? ObjectId.PRIMITIVE_BLOCK;
        ObjectSettings = objectSettings;
        Material = material;
    }

}
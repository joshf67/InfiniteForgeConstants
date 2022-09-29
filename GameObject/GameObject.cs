// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

using InfiniteForgeConstants.MaterialSettings;

namespace InfiniteForgeConstants.ObjectSettings;

/// <summary>
/// Class that all data required for a forge object.
/// </summary>
public class GameObject
{
    public string Name;
    public ObjectId ObjectId;

    public Transform Transform;
    public Material? Material;
    public AdditionalObjectSettings? ObjectSettings;

    /// <summary>
    /// Create a GameObject(Forge Object) from optional parameters.
    /// </summary>
    /// <param name="name"> The name to be given to this object in game. </param>
    /// <param name="objectId"> The id of this object in game. </param>
    /// <param name="transform"> The data that relates to positioning/rotation... etc of this object. </param>
    /// <param name="objectSettings"> The additional data this object may require. </param>
    /// <param name="material"> The material data this object has. </param>
    public GameObject(string? name = "Object", ObjectId? objectId = ObjectId.PRIMITIVE_BLOCK, Transform? transform = null, AdditionalObjectSettings? objectSettings = null, Material? material = null)
    {
        Name = name ?? "Object";
        ObjectId = objectId ?? ObjectId.PRIMITIVE_BLOCK;
        Transform = transform ?? new Transform();
        ObjectSettings = objectSettings ?? new AdditionalObjectSettings();
        ObjectSettings = objectSettings;
        Material = material;
    }

}
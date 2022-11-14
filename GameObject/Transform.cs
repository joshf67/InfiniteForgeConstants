// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

using System.Numerics;
// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace InfiniteForgeConstants.ObjectSettings;

/// <summary>
/// Class that stores all data of a transform for a GameObject (Forge Object)
/// </summary>
public class Transform
{
    private readonly Vector3 _forward = new Vector3(0, 0, 1);
    private readonly Vector3 _up = new Vector3(0, 1, 0);

    public Vector3 Position;
    public Vector3 ImperialPosition => Position * 3.2808f;
    public Vector3 MetricPosition => Position / 3.2808f;

    public bool IsStatic;
    public PhysicsType PhysicsType;
    public Vector3 Scale;

    private Quaternion _rotation;

    /// <summary>
    /// Returns the Quaternion Rotation of this transform.
    /// </summary>
    public Quaternion Rotation
    {
        get => _rotation;
        set => _rotation = value;
    }

    /// <summary>
    /// Returns the Euler Rotation of this transform
    /// </summary>
    public Vector3 EulerRotation
    {
        get => new Vector3(_rotation.X, _rotation.Y, _rotation.Z);
        set => _rotation = Quaternion.CreateFromYawPitchRoll(value.X, value.Y, value.Z);
    }

    /// <summary>
    /// Returns the forward and up direction vectors of this transform
    /// </summary>
    public (Vector3 Forward, Vector3 Up) DirectionVectors =>
        (Vector3.Transform(_forward, Rotation), Vector3.Transform(_up, Rotation));

    /// <summary>
    /// Creates a transform from all optional parameters using euler rotation.
    /// </summary>
    /// <param name="position"> The vector3 position of this object. </param>
    /// <param name="rotation"> The vector3 (Euler) rotation to generate rotation from. </param>
    /// <param name="isStatic"> Determines if this object is static or dynamic. </param>
    /// <param name="physicsType"> The physics type this object has when dynamic. </param>
    /// <param name="scale"> The vector3 scale of this object. </param>
    public Transform(Vector3? position = null, Vector3? rotation = null, bool? isStatic = false, PhysicsType? physicsType = PhysicsType.PHASED, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        EulerRotation = rotation ?? Vector3.Zero;
        IsStatic = isStatic ?? false;
        PhysicsType = physicsType ?? PhysicsType.PHASED;
        Scale = scale ?? Vector3.One;
    }

    /// <summary>
    /// Creates a transform using direction unit vectors.
    /// </summary>
    /// <param name="position"> The vector3 position of this object. </param>
    /// <param name="directionVectors"> The forward and up direction vectors to generate rotation from. </param>
    /// <param name="isStatic"> Determines if this object is static or dynamic. </param>
    /// <param name="physicsType"> The physics type this object has when dynamic. </param>
    /// <param name="scale"> The vector3 scale of this object. </param>
    public Transform(Vector3 position, (Vector3 Forward, Vector3 Up) directionVectors,
        bool? isStatic = false, PhysicsType? physicsType = PhysicsType.PHASED, Vector3? scale = null)
    {
        Position = position;
        EulerRotation = DirectionToEuler(directionVectors.Forward, directionVectors.Up).Degrees;
        IsStatic = isStatic ?? false;
        PhysicsType = physicsType ?? PhysicsType.PHASED;
        Scale = scale ?? Vector3.One;
    }

    /// <summary>
    /// Creates a transform using a quaternion rotation.
    /// </summary>
    /// <param name="position"> The vector3 position of this object. </param>
    /// <param name="rotation"> The quaternion rotation of this object. </param>
    /// <param name="isStatic"> Determines if this object is static or dynamic. </param>
    /// <param name="physicsType"> The physics type this object has when dynamic. </param>
    /// <param name="scale"> The vector3 scale of this object. </param>
    public Transform(Vector3? position, Quaternion? rotation, bool? isStatic = false, PhysicsType? physicsType = PhysicsType.PHASED, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        Rotation = rotation ?? Quaternion.CreateFromYawPitchRoll(0, 0, 0);
        IsStatic = isStatic ?? false;
        PhysicsType = physicsType ?? PhysicsType.PHASED;
        Scale = scale ?? Vector3.One;
    }

    /// <summary>
    /// Converts a forward and up unit vector into a euler rotation
    /// </summary>
    /// <param name="forward"> The forward unit vector to use. </param>
    /// <param name="up"> The up unit vector to use. </param>
    /// <returns> The euler rotation in radians and degrees </returns>
    public static (Vector3 Radians, Vector3 Degrees) DirectionToEuler(Vector3 forward, Vector3 up)
    {
        if (forward == Vector3.Zero && up == Vector3.Zero || forward == up)
            return (Vector3.Zero, Vector3.Zero);
            
        var z = MathF.Acos(Vector3.Dot(Vector3.UnitX, Vector3.Normalize(forward with { Z = 0 }))) *
                Vector3.Normalize(new Vector3(0, forward.Y, 0)).Y;

        var y = MathF.Acos(Vector3.Dot(Vector3.UnitZ, forward)) - (MathF.PI / 2);

        var x = MathF.Acos(Vector3.Dot(Vector3.UnitZ, Vector3.Cross(forward, up)));

        return (new Vector3(x, y, z), new Vector3(x, y, z) * (180 / MathF.PI));
    }
}
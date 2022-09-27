using System.Numerics;

namespace InfiniteForgeConstants.ObjectSettings;

public class Transform
{
    private readonly Vector3 _forward = new Vector3(0, 0, 1);
    private readonly Vector3 _up = new Vector3(0, 1, 0);

    /// <summary>
    /// (0 Normal, 1 Fixed, 2 Phased)
    /// </summary>
    public PhysicsMode PhysicsMode { get; set; } = PhysicsMode.PHASED;

    public Vector3 Position;
    public Vector3 ImperialPosition => Position * 3.2808f;
    public Vector3 MetricPosition => Position / 3.2808f;

    public bool IsStatic;
    public Vector3 Scale;

    private Quaternion _rotation;

    public Quaternion Rotation
    {
        get => _rotation;
        set => _rotation = value;
    }

    public Vector3 EulerRotation
    {
        get => new Vector3(_rotation.X, _rotation.Y, _rotation.Z);
        set => _rotation = Quaternion.CreateFromYawPitchRoll(value.X, value.Y, value.Z);
    }

    public (Vector3 Forward, Vector3 Up) DirectionVectors =>
        (Vector3.Transform(_forward, Rotation), Vector3.Transform(_up, Rotation));

    public Transform(Vector3? position = null, Vector3? rotation = null, bool? isStatic = false, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        EulerRotation = rotation ?? Vector3.Zero;
        IsStatic = isStatic ?? false;
        Scale = scale ?? Vector3.One;
    }

    public Transform(Vector3 position, (Vector3 Forward, Vector3 Up) directionVectors,
        bool? isStatic = false, Vector3? scale = null)
    {
        Position = position;
        EulerRotation = DirectionToEuler(directionVectors.Forward, directionVectors.Up).Degrees;
        IsStatic = isStatic ?? false;
        Scale = scale ?? Vector3.One;
    }

    public Transform(Vector3? position, Quaternion? rotation, bool? isStatic = false, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        Rotation = rotation ?? Quaternion.CreateFromYawPitchRoll(0, 0, 0);
        IsStatic = isStatic ?? false;
        Scale = scale ?? Vector3.One;
    }

    public static (Vector3 Radians, Vector3 Degrees) DirectionToEuler(Vector3 forward, Vector3 up)
    {
        var z = MathF.Acos(Vector3.Dot(Vector3.UnitX, Vector3.Normalize(forward with { Z = 0 }))) *
                Vector3.Normalize(new Vector3(0, forward.Y, 0)).Y;

        var y = MathF.Acos(Vector3.Dot(Vector3.UnitZ, forward)) - (MathF.PI / 2);

        var x = MathF.Acos(Vector3.Dot(Vector3.UnitZ, Vector3.Cross(forward, up)));

        return (new Vector3(x, y, z), new Vector3(x, y, z) * (180 / MathF.PI));
    }
}

public enum PhysicsMode
{
    NORMAL = 0,
    FIXED = 1,
    PHASED = 2
}
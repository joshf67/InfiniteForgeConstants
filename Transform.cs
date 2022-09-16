using System.Numerics;

namespace InfiniteForgeConstants;

public class Transform
{
    private readonly Vector3 _forward = new Vector3(0, 0, 1);
    private readonly Vector3 _up = new Vector3(0, 1, 0);

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
    
    public (Vector3 Forward, Vector3 Up) DirectionVectors => (Vector3.Transform(_forward, Rotation), Vector3.Transform(_up, Rotation));

    public Transform(Vector3? position = null, Vector3? rotation = null, bool? isStatic = false, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        EulerRotation = rotation ?? Vector3.Zero;
        IsStatic = isStatic ?? false;
        Scale = scale ?? Vector3.One;
    }

    public Transform(Vector3? position, Quaternion? rotation, bool? isStatic = false, Vector3? scale = null)
    {
        Position = position ?? Vector3.Zero;
        Rotation = rotation ?? Quaternion.CreateFromYawPitchRoll(0,0,0);
        IsStatic = isStatic ?? false;
        Scale = scale ?? Vector3.One;
    }
}
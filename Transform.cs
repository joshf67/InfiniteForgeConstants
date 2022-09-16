using System.Numerics;

namespace InfiniteForgeConstants;

public class Transform
{
    private readonly Vector3 _forward = new Vector3(0, 0, 1);
    private readonly Vector3 _up = new Vector3(0, 1, 0);

    public Vector3 Position;
    public Vector3 ImperialPosition => Position * 3.2808f;
    public Vector3 MetricPosition => Position / 3.2808f;

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

    public Transform(Vector3? position, Vector3? rotation, Vector3? scale)
    {
        Position = position ?? Vector3.Zero;
        EulerRotation = rotation ?? Vector3.Zero;
        Scale = scale ?? Vector3.One;
    }

    public Transform(Vector3? position, Quaternion? rotation, Vector3? scale)
    {
        Position = position ?? Vector3.Zero;
        Rotation = rotation ?? Quaternion.CreateFromYawPitchRoll(0,0,0);
        Scale = scale ?? Vector3.One;
    }

    public Transform()
    {
        Position = Vector3.Zero;
        EulerRotation = Vector3.Zero;
        Scale = Vector3.One;
    }

    public (Vector3 Forward, Vector3 Up) ConvertToDirectionVectors()
    {
        return (Vector3.Transform(_forward, Rotation), Vector3.Transform(_up, Rotation));
    }
}
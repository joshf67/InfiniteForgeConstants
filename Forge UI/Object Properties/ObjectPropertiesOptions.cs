namespace InfiniteForgeConstants.Forge_UI.Object_Properties;

public static class ObjectPropertiesOptions
{
    public static Dictionary<ObjectPropertyName, int> StaticByDefault = new()
    {
        { ObjectPropertyName.GeneralDropdown, 0 },
        { ObjectPropertyName.ObjectName, 1 },
        { ObjectPropertyName.ObjectModeDropdown, 2 },
        { ObjectPropertyName.ObjectMode, 3 },
        { ObjectPropertyName.SizeX, 4 },
        { ObjectPropertyName.SizeY, 5 },
        { ObjectPropertyName.SizeZ, 6 },
        { ObjectPropertyName.Physics, 7 },
        { ObjectPropertyName.TransformDropdown, 8 },
        { ObjectPropertyName.PositionDropdown, 9 },
        { ObjectPropertyName.Forward, 10 },
        { ObjectPropertyName.Horizontal, 11 },
        { ObjectPropertyName.Vertical, 12 },
        { ObjectPropertyName.RotationDropdown, 13 },
        { ObjectPropertyName.Yaw, 14 },
        { ObjectPropertyName.Pitch, 15 },
        { ObjectPropertyName.Roll, 16 },
        { ObjectPropertyName.Reset, 17 }
    };
}
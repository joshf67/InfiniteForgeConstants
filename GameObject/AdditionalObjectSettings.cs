// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

namespace InfiniteForgeConstants.ObjectSettings;

/// <summary>
/// Class that contains any extra data required for object to exist in forge.
/// </summary>
public class AdditionalObjectSettings
{
    public int VariantId;

    /// <summary>
    /// Create an object's additional settings.
    /// </summary>
    /// <param name="variantId"> The variant Id to use when this object has one. </param>
    public AdditionalObjectSettings(int variantId)
    {
        VariantId = variantId;
    }
}
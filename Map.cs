// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS1591

using InfiniteForgeConstants.MapSettings;
using InfiniteForgeConstants.MapSettings.AmbientSound;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants;

/// <summary>
/// Class that holds all data of a map, map settings, objects...
/// </summary>
public class Map
{
    public MapId? MapId;
    public bool? Decorators;
    public ScreenEffectId? ScreenEffectId;
    public MapOptions? Options;
    public AmbientSound? AmbientSound;
    public List<GameObject>? GameObjects;

    /// <summary>
    /// Create a map from all optional parameters
    /// </summary>
    /// <param name="mapId"> The specific id of this map. </param>
    /// <param name="decorators"> Determines if decorators should be used. </param>
    /// <param name="screenEffectId"> The data for all map screen effects. </param>
    /// <param name="options"> The data for all settings of this map. </param>
    /// <param name="ambientSound"> The data for all sound options of this map. </param>
    /// <param name="gameObjects"> The data for all objects on this map. </param>
    public Map(MapId? mapId = MapSettings.MapId.AQUARIUS, bool? decorators = null, ScreenEffectId? screenEffectId = null,
        MapOptions? options = null, AmbientSound? ambientSound = null, List<GameObject>? gameObjects = null)
    {
        MapId = mapId;
        Decorators = decorators;
        ScreenEffectId = screenEffectId;
        Options = options;
        AmbientSound = ambientSound;
        GameObjects = gameObjects ?? new List<GameObject>();
    }
}
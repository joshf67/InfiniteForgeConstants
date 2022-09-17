using InfiniteForgeConstants.MapSettings;
using InfiniteForgeConstants.MapSettings.AmbientSound;
using InfiniteForgeConstants.ObjectSettings;

namespace InfiniteForgeConstants;

public class Map
{
    public MapId MapId { get; set; }
    public bool? Decorators;
    public ScreenEffectId? ScreenEffectId;
    public MapOptions? Options;
    public AmbientSound? AmbientSound;
    
    public List<GameObject> GameObjects { get; set; }

    public Map(MapId mapId = MapId.AQUARIUS, bool? decorators = null, ScreenEffectId? screenEffectId = null,
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
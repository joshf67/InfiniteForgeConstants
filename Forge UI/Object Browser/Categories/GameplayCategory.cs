using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Gameplay;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class GameplayCategory : ForgeUICategory
{
    public GameplayCategory(int order) : base("Gameplay", order)
    {
        AddFolder(new AudioFolder());
        AddFolder(new EquipmentFolder());
        AddFolder(new GameModesFolder());
        AddFolder(new LaunchersLiftsFolder());
        AddFolder(new MatchFlowFolder());
        AddFolder(new NavMeshFolder());
        AddFolder(new PlayerSpawningFolder());
        AddFolder(new SandboxFolder());
        AddFolder(new ScriptingFolder());
        AddFolder(new TeleportersFolder());
        AddFolder(new VehiclesFolder());
        AddFolder(new VolumesFolder());
        AddFolder(new WeaponSpawnersFolder());
        AddFolder(new WeaponsFolder());
    }
}
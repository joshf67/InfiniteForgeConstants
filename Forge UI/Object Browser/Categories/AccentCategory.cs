using InfiniteForgeConstants.Forge_UI.Object_Browser.Folders.Accents;

namespace InfiniteForgeConstants.Forge_UI.Object_Browser;

public class AccentCategory : ForgeUICategory
{
    public AccentCategory(int order) : base("Accent", order)
    {
        AddFolder(new AntennasFolder());
        AddFolder(new AntennasMPFolder());
        AddFolder(new ArenaFolder());
        AddFolder(new BarrelsFolder());
        AddFolder(new BarrelsMPFolder());
        AddFolder(new BazaarFolder());
        AddFolder(new BazaarMPFolder());
        AddFolder(new BodiesFolder());
        AddFolder(new CityPropsFolder());
        AddFolder(new CityPropsMPFolder());
        AddFolder(new CoverFolder());
        AddFolder(new CoverMPFolder());
        AddFolder(new CratesFolder());
        AddFolder(new CratesMPFolder());
        AddFolder(new DestructiblesFolder());
        AddFolder(new DestructiblesMPFolder());
        AddFolder(new DuctsFolder());
        AddFolder(new FencesFolder());
        AddFolder(new FencesMPFolder());
        AddFolder(new ForerunnerFolder());
        AddFolder(new ForerunnerMPFolder());
        AddFolder(new GarbageFolder());
        AddFolder(new GarbageMPFolder());
        AddFolder(new GlassFolder());
        AddFolder(new MissilesFolder());
        AddFolder(new MissilesMPFolder());
        AddFolder(new PanelsFolder());
        AddFolder(new PipesFolder());
        AddFolder(new RailingsFolder());
        AddFolder(new RailingsMPFolder());
        AddFolder(new RubbleFolder());
        AddFolder(new SandbagsFolder());
        AddFolder(new SandbagsMPFolder());
        AddFolder(new SignsFolder());
        AddFolder(new SupportsFolder());
        AddFolder(new ToolsMPFolder());
        AddFolder(new UNSCFolder());
        AddFolder(new UNSCMPFolder());
        AddFolder(new VehiclesFolder());
        AddFolder(new VehiclesMPFolder());
        AddFolder(new WiresFolder());
        AddFolder(new WiresMPFolder());
        AddFolder(new WorkstationsFolder());
        AddFolder(new WorkstationsMPFolder());
    }
}
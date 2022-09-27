# InfiniteForgeConstants

A baseline data structure of halo infinite's forge objects to increase code interoperability.

[.mvar cheat sheet](https://gist.github.com/joshf67/7cc15f31e54db7466671d84e4f9b1630)

---

## Enums

## Classes
- **Map**: The Class that roughly represents the .mvar file, This is the highest level object in the hierarchy

---

### GameObjects
**Namespace**: ObjectSettings
#### Enums

- **ObjectId**:  All known forge object's object ids
 
#### Classes
- **GameObject**: Main Class for objects, Holds reference to required data about a forge object
- **Transform**: Generic Position, Rotation and Scale variables stored in one class with helper functions
```diff
+ thanks to Artifice for the conversion from direction vectors to euler angles
```
- **AdditonalObjectSettings**: Used for other stuff like variant ids etc

---

### Materials
**Namespace**: MaterialSettings

#### Enums
- **SwatchId**: All known Swatch Ids for forge objects
- **Metal Type**: Enum for deciphering material swatch metal type, on/off/source
- **GrimeId**: All known Grime Ids for forge objects

#### Classes
- **Material**: Class to hold data about a forge object's material settings, scratch grime.. etc
- **Material Region**: Class to hold data about Material Region Swatches, color... etc
- **Material Grime**: Class to hold data about Object's grime section, grime/scratch

---

### Map Options
**Namespace**: MapSettings

#### Enums

- **MapId**: All map ids
- **ScreenEffectId**: All map screen effect ids
- **PrimarySoundsId**: All map primary sound ids
- **SecondaySoundId**: All map secondary sound ids
- **ReverbId**: All map reverb ids
- **AudioEffectId**: All map audio effect ids
- **ColorId**: All color picker options

#### Classes

- **MapOptions**: Class to hold all data about the map
- **Sunlight**: Options to control a map's sunlight
- **LightBounce**: Options to control a map's light bounce
- **Skylight**: Options to control a map's skylight
- **DirectionalSkyLight**: Options to override a map's Skylight options
- **WindDirection**: Options to control a map's wind
- **VolumetricFog**: Options to control a map's volumetric fog
- **SkyRendering**: Options to control a map's sky rendering
- **AtmosphericFog**: Options to control a map's atmospheric fog
- **AmbientSound**: Class to hold all data about a map's sound options


---


### Map Options
**Namespace**: NodeGraphSettings

#### Enums

- **EquipmentTypes**: All Node Graph equipment types selectable when using equipment nodes
- **GrenadeTypes**: All Node Graph grenade types selectable when using grenade nodes
- **StringTypes**: All Node Graph strings selectable when using string nodes
- **TeamTypes**: All Node Graph equipment types selectable when using team nodes
- **VehicleTypes**: All Node Graph equipment types selectable when using vehicle nodes
- **WeaponTypes**: All Node Graph base weapon types selectable when using weapon nodes
- **WeaponCombinationBaseTypes**: All Node Graph base weapon types selectable when combining weapon types
- **WeaponCombinationConfigurationTypes**: All Node Graph configuration types selectable when combining weapon types


---
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
- **Transform**: Generic Position, Rotation and Scale variables stored in 1 class with helper functions
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
- **AmbientSound**: Class to hold all data about a map's sound options
- **Sunlight**: Options to control a map's sunlight
- **Skylight**: Options to control a map's skylight
- **DirectionalSkyLight**: Options to override a map's Skylight options
- **LightBounce**: Options to control a map's light bounce

---
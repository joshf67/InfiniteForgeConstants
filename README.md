# InfiniteForgeConstants

A baseline data structure of halo infinite's forge objects to increase code interoperability.

[.mvar cheat sheet](https://gist.github.com/joshf67/7cc15f31e54db7466671d84e4f9b1630)

### Enums

- **ObjectId**:  All known forge object's object Id
- **MapId**: All map ids

### Classes
- **Map**: The Class that roughly represents the .mvar file, This is the highest level object in the hierarchy

- **GameObject**: Main Class for objects, Holds reference to required data about a forge object

- **Transform**: Generic Position, Rotation and Scale variables stored in 1 class with helper functions
- **AdditonalObjectSettings**: Used for other stuff like variant ids etc

#### Material Classes

- **Material**: Class to hold data about a forge object's material settings, scratch grime.. etc

- **Material Region**: Class to hold data about Material Region Swatches, color... etc

- **SwatchId**: All known Swatch Ids for forge objects

- **Metal Type**: Enum for deciphering material swatch metal type, on/off/source

- **Material Grime**: Class to hold data about Object's grime section, grime/scratch

- **GrimeId**: All known Grime Ids for forge objects

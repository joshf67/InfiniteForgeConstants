# InfiniteForgeConstants
A baseline data structure of halo infinite's forge objects to increase code interoperability. 

GameObject = Main Class for objects, Holds reference to required data about a forge object

ObjectId = All known forge object's object Id
Transform = Generic Position, Rotation and Scale variables stored in 1 class with helper functions
AdditonalObjectSettings = Used for other stuff like variant ids etc

Material = Class to hold data about a forge object's material settings, scratch grime.. etc
MaterialRegion = Class to hold data about Material Region Swatches, color... etc
SwatchId = All known Swatch Ids for forge objects
MetalType = Enum for deciphering material swatch metal type, on/off/source
MaterialGrime = Class to hold data about Object's grime section, grime/scratch
GrimeId = All known Grime Ids for forge objects

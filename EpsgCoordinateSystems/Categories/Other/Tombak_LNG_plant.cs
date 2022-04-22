namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tombak_LNG_plant : IEpsgCoordinateSystem
    {
        public string Name => "Tombak LNG plant";
        public string Units => "Unspecified";
public int Srid => 5817;

        public string OgcWkt =>
            "LOCAL_CS[Tombak LNG plant,LOCAL_DATUM[Tombak LNG plant,0,AUTHORITY[EPSG,9314]],UNIT[m,1.0],AXIS[Plant East,NORTH_EAST],AXIS[Plant North,NORTH_WEST],AUTHORITY[EPSG,5817]]";

        public string EsriWkt => "";
    }
}
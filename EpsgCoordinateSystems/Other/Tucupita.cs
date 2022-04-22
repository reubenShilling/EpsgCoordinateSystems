namespace EpsgCoordinateSystems.Other
{
    public class Tucupita : IEpsgCoordinateSystem
    {
        public string Name => "Tucupita";
        public string Units => "Unspecified";
public long Srid => 5814;

        public string OgcWkt =>
            "LOCAL_CS[Tucupita,LOCAL_DATUM[Tucupita,0,AUTHORITY[EPSG,9308]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5814]]";

        public string EsriWkt =>
            "LOCAL_CS[Tucupita,LOCAL_DATUM[Tucupita,0,AUTHORITY[EPSG,9308]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5814]]";
    }
}
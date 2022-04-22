namespace EpsgCoordinateSystems.Other
{
    public class Mene_Grande : IEpsgCoordinateSystem
    {
        public string Name => "Mene Grande";
        public string Units => "Unspecified";
public long Srid => 5811;

        public string OgcWkt =>
            "LOCAL_CS[Mene Grande,LOCAL_DATUM[Mene Grande,0,AUTHORITY[EPSG,9305]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5811]]";

        public string EsriWkt => "";
    }
}
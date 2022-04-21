namespace EpsgCoordinateSystems.Other
{
    public class Dabajuro : IEpsgCoordinateSystem
    {
        public string Name => "Dabajuro";
        public long Srid => 5813;

        public string OgcWkt =>
            "LOCAL_CS[Dabajuro,LOCAL_DATUM[Dabajuro,0,AUTHORITY[EPSG,9307]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5813]]";

        public string EsriWkt =>
            "LOCAL_CS[Dabajuro,LOCAL_DATUM[Dabajuro,0,AUTHORITY[EPSG,9307]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5813]]";
    }
}
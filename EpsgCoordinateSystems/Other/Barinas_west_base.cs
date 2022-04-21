namespace EpsgCoordinateSystems.Other
{
    public class Barinas_west_base : IEpsgCoordinateSystem
    {
        public string Name => "Barinas west base";
        public long Srid => 5816;

        public string OgcWkt =>
            "LOCAL_CS[Barinas west base,LOCAL_DATUM[Barinas west base,0,AUTHORITY[EPSG,9311]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5816]]";

        public string EsriWkt =>
            "LOCAL_CS[Barinas west base,LOCAL_DATUM[Barinas west base,0,AUTHORITY[EPSG,9311]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5816]]";
    }
}
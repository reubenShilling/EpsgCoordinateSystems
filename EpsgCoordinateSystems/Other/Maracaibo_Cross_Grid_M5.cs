namespace EpsgCoordinateSystems.Other
{
    public class Maracaibo_Cross_Grid_M5 : IEpsgCoordinateSystem
    {
        public string Name => "Maracaibo Cross Grid M5";
        public long Srid => 5809;

        public string OgcWkt =>
            "LOCAL_CS[Maracaibo Cross Grid M5,LOCAL_DATUM[Maracaibo Cross,0,AUTHORITY[EPSG,9303]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5809]]";

        public string EsriWkt =>
            "LOCAL_CS[Maracaibo Cross Grid M5,LOCAL_DATUM[Maracaibo Cross,0,AUTHORITY[EPSG,9303]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5809]]";
    }
}
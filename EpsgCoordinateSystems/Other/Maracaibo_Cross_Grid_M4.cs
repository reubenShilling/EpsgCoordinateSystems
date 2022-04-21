namespace EpsgCoordinateSystems.Other
{
    public class Maracaibo_Cross_Grid_M4 : IEpsgCoordinateSystem
    {
        public string Name => "Maracaibo Cross Grid M4";
        public long Srid => 5808;

        public string OgcWkt =>
            "LOCAL_CS[Maracaibo Cross Grid M4,LOCAL_DATUM[Maracaibo Cross,0,AUTHORITY[EPSG,9303]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5808]]";

        public string EsriWkt =>
            "LOCAL_CS[Maracaibo Cross Grid M4,LOCAL_DATUM[Maracaibo Cross,0,AUTHORITY[EPSG,9303]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5808]]";
    }
}
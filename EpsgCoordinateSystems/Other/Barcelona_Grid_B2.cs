namespace EpsgCoordinateSystems.Other
{
    public class Barcelona_Grid_B2 : IEpsgCoordinateSystem
    {
        public string Name => "Barcelona Grid B2";
        public long Srid => 5802;

        public string OgcWkt =>
            "LOCAL_CS[Barcelona Grid B2,LOCAL_DATUM[Barcelona,0,AUTHORITY[EPSG,9301]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5802]]";

        public string EsriWkt =>
            "LOCAL_CS[Barcelona Grid B2,LOCAL_DATUM[Barcelona,0,AUTHORITY[EPSG,9301]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5802]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class El_Cubo : IEpsgCoordinateSystem
    {
        public string Name => "El Cubo";
        public long Srid => 5812;

        public string OgcWkt =>
            "LOCAL_CS[El Cubo,LOCAL_DATUM[El Cubo,0,AUTHORITY[EPSG,9306]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5812]]";

        public string EsriWkt =>
            "LOCAL_CS[El Cubo,LOCAL_DATUM[El Cubo,0,AUTHORITY[EPSG,9306]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5812]]";
    }
}
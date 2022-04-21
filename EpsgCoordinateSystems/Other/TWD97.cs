namespace EpsgCoordinateSystems.Other
{
    public class TWD97 : IEpsgCoordinateSystem
    {
        public string Name => "TWD97";
        public long Srid => 3824;

        public string OgcWkt =>
            "GEOGCS[TWD97,DATUM[Taiwan Datum 1997,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,1026]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3824]]";

        public string EsriWkt =>
            "GEOGCS[TWD97,DATUM[Taiwan Datum 1997,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,1026]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3824]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class POSGAR_94 : IEpsgCoordinateSystem
    {
        public string Name => "POSGAR 94";
        public long Srid => 4929;

        public string OgcWkt =>
            "GEOGCS[POSGAR 94,DATUM[Posiciones Geodesicas Argentinas 1994,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6694]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4929]]";

        public string EsriWkt =>
            "GEOGCS[POSGAR 94,DATUM[Posiciones Geodesicas Argentinas 1994,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6694]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4929]]";
    }
}
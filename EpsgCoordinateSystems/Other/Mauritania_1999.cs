namespace EpsgCoordinateSystems.Other
{
    public class Mauritania_1999 : IEpsgCoordinateSystem
    {
        public string Name => "Mauritania 1999";
        public string Units => "Unspecified";
public long Srid => 4925;

        public string OgcWkt =>
            "GEOGCS[Mauritania 1999,DATUM[Mauritania 1999,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6702]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4925]]";

        public string EsriWkt =>
            "GEOGCS[Mauritania 1999,DATUM[Mauritania 1999,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6702]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4925]]";
    }
}
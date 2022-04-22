namespace EpsgCoordinateSystems.Other
{
    public class REGVEN : IEpsgCoordinateSystem
    {
        public string Name => "REGVEN";
        public string Units => "Unspecified";
public long Srid => 4963;

        public string OgcWkt =>
            "GEOGCS[REGVEN,DATUM[Red Geodesica Venezolana,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6189]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4963]]";

        public string EsriWkt =>
            "GEOGCS[REGVEN,DATUM[Red Geodesica Venezolana,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6189]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4963]]";
    }
}
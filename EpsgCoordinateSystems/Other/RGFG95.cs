namespace EpsgCoordinateSystems.Other
{
    public class RGFG95 : IEpsgCoordinateSystem
    {
        public string Name => "RGFG95";
        public long Srid => 4967;

        public string OgcWkt =>
            "GEOGCS[RGFG95,DATUM[Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2.0,2.0,-2.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4967]]";

        public string EsriWkt =>
            "GEOGCS[RGFG95,DATUM[Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2.0,2.0,-2.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4967]]";
    }
}
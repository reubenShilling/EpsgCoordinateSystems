namespace EpsgCoordinateSystems.Other
{
    public class BDA2000 : IEpsgCoordinateSystem
    {
        public string Name => "BDA2000";
        public string Units => "Unspecified";
public long Srid => 4887;

        public string OgcWkt =>
            "GEOGCS[BDA2000,DATUM[Bermuda 2000,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6762]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4887]]";

        public string EsriWkt =>
            "GEOGCS[BDA2000,DATUM[Bermuda 2000,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6762]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4887]]";
    }
}
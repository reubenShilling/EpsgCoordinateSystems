namespace EpsgCoordinateSystems.Other
{
    public class LGD2006 : IEpsgCoordinateSystem
    {
        public string Name => "LGD2006";
        public string Units => "Unspecified";
public long Srid => 4900;

        public string OgcWkt =>
            "GEOGCS[LGD2006,DATUM[Libyan Geodetic Datum 2006,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[-208.4058,-109.8777,-2.5764,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6754]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4900]]";

        public string EsriWkt =>
            "GEOGCS[LGD2006,DATUM[Libyan Geodetic Datum 2006,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[-208.4058,-109.8777,-2.5764,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6754]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4900]]";
    }
}
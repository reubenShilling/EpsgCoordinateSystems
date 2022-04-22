namespace EpsgCoordinateSystems.Other
{
    public class NZGD2000 : IEpsgCoordinateSystem
    {
        public string Name => "NZGD2000";
        public string Units => "Unspecified";
public long Srid => 4959;

        public string OgcWkt =>
            "GEOGCS[NZGD2000,DATUM[New Zealand Geodetic Datum 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4959]]";

        public string EsriWkt =>
            "GEOGCS[NZGD2000,DATUM[New Zealand Geodetic Datum 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4959]]";
    }
}
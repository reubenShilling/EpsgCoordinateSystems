namespace EpsgCoordinateSystems.Other
{
    public class TWD67 : IEpsgCoordinateSystem
    {
        public string Name => "TWD67";
        public string Units => "Unspecified";
public long Srid => 3821;

        public string OgcWkt =>
            "GEOGCS[TWD67,DATUM[Taiwan Datum 1967,SPHEROID[GRS 1967 Modified,6378160.0,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,1025]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3821]]";

        public string EsriWkt =>
            "GEOGCS[TWD67,DATUM[Taiwan Datum 1967,SPHEROID[GRS 1967 Modified,6378160.0,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,1025]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3821]]";
    }
}
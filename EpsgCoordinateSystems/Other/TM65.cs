namespace EpsgCoordinateSystems.Other
{
    public class TM65 : IEpsgCoordinateSystem
    {
        public string Name => "TM65";
        public string Units => "Unspecified";
public long Srid => 4299;

        public string OgcWkt =>
            "GEOGCS[TM65,DATUM[TM65,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6299]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4299]]";

        public string EsriWkt =>
            "GEOGCS[TM65,DATUM[TM65,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6299]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4299]]";
    }
}
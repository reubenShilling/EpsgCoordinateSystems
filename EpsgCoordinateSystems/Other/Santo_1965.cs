namespace EpsgCoordinateSystems.Other
{
    public class Santo_1965 : IEpsgCoordinateSystem
    {
        public string Name => "Santo 1965";
        public string Units => "Unspecified";
public long Srid => 4730;

        public string OgcWkt =>
            "GEOGCS[Santo 1965,DATUM[Santo_1965,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[170,42,84,0,0,0,0],AUTHORITY[EPSG,6730]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4730]]";

        public string EsriWkt =>
            "GEOGCS[Santo 1965,DATUM[Santo_1965,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[170,42,84,0,0,0,0],AUTHORITY[EPSG,6730]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4730]]";
    }
}
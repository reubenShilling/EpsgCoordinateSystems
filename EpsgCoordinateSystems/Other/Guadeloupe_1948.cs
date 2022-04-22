namespace EpsgCoordinateSystems.Other
{
    public class Guadeloupe_1948 : IEpsgCoordinateSystem
    {
        public string Name => "Guadeloupe 1948";
        public string Units => "Unspecified";
public long Srid => 4622;

        public string OgcWkt =>
            "GEOGCS[Guadeloupe 1948,DATUM[Guadeloupe_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6622]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4622]]";

        public string EsriWkt =>
            "GEOGCS[Guadeloupe 1948,DATUM[Guadeloupe_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6622]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4622]]";
    }
}
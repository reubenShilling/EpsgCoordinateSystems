namespace EpsgCoordinateSystems.Other
{
    public class Lisbon : IEpsgCoordinateSystem
    {
        public string Name => "Lisbon";
        public long Srid => 4207;

        public string OgcWkt =>
            "GEOGCS[Lisbon,DATUM[Lisbon_1937,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6207]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4207]]";

        public string EsriWkt =>
            "GEOGCS[Lisbon,DATUM[Lisbon_1937,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6207]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4207]]";
    }
}
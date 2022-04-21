namespace EpsgCoordinateSystems.Other
{
    public class Helle_1954 : IEpsgCoordinateSystem
    {
        public string Name => "Helle 1954";
        public long Srid => 4660;

        public string OgcWkt =>
            "GEOGCS[Helle 1954,DATUM[Helle_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[982.609,552.753,-540.873,32.3934,-153.257,-96.2266,16.805],AUTHORITY[EPSG,6660]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4660]]";

        public string EsriWkt =>
            "GEOGCS[Helle 1954,DATUM[Helle_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[982.609,552.753,-540.873,32.3934,-153.257,-96.2266,16.805],AUTHORITY[EPSG,6660]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4660]]";
    }
}
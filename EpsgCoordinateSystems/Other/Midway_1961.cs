namespace EpsgCoordinateSystems.Other
{
    public class Midway_1961 : IEpsgCoordinateSystem
    {
        public string Name => "Midway 1961";
        public long Srid => 4727;

        public string OgcWkt =>
            "GEOGCS[Midway 1961,DATUM[Midway_1961,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6727]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4727]]";

        public string EsriWkt =>
            "GEOGCS[Midway 1961,DATUM[Midway_1961,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6727]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4727]]";
    }
}
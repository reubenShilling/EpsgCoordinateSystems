namespace EpsgCoordinateSystems.Other
{
    public class Solomon_1968 : IEpsgCoordinateSystem
    {
        public string Name => "Solomon 1968";
        public long Srid => 4718;

        public string OgcWkt =>
            "GEOGCS[Solomon 1968,DATUM[Solomon_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6718]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4718]]";

        public string EsriWkt =>
            "GEOGCS[Solomon 1968,DATUM[Solomon_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6718]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4718]]";
    }
}
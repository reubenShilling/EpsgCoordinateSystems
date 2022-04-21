namespace EpsgCoordinateSystems.Other
{
    public class Egypt_1930 : IEpsgCoordinateSystem
    {
        public string Name => "Egypt 1930";
        public long Srid => 4199;

        public string OgcWkt =>
            "GEOGCS[Egypt 1930,DATUM[Egypt_1930,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6199]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4199]]";

        public string EsriWkt =>
            "GEOGCS[Egypt 1930,DATUM[Egypt_1930,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6199]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4199]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Easter_Island_1967 : IEpsgCoordinateSystem
    {
        public string Name => "Easter Island 1967";
        public long Srid => 4719;

        public string OgcWkt =>
            "GEOGCS[Easter Island 1967,DATUM[Easter_Island_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[211,147,111,0,0,0,0],AUTHORITY[EPSG,6719]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4719]]";

        public string EsriWkt =>
            "GEOGCS[Easter Island 1967,DATUM[Easter_Island_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[211,147,111,0,0,0,0],AUTHORITY[EPSG,6719]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4719]]";
    }
}
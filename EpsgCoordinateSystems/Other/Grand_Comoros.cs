namespace EpsgCoordinateSystems.Other
{
    public class Grand_Comoros : IEpsgCoordinateSystem
    {
        public string Name => "Grand Comoros";
        public long Srid => 4646;

        public string OgcWkt =>
            "GEOGCS[Grand Comoros,DATUM[Grand_Comoros,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6646]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4646]]";

        public string EsriWkt =>
            "GEOGCS[Grand Comoros,DATUM[Grand_Comoros,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6646]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4646]]";
    }
}
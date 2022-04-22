namespace EpsgCoordinateSystems.Other
{
    public class Qornoq_1927 : IEpsgCoordinateSystem
    {
        public string Name => "Qornoq 1927";
        public string Units => "Unspecified";
public long Srid => 4194;

        public string OgcWkt =>
            "GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194]]";

        public string EsriWkt =>
            "GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194]]";
    }
}
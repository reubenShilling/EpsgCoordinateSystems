namespace EpsgCoordinateSystems.Other
{
    public class Dealul_Piscului_1933 : IEpsgCoordinateSystem
    {
        public string Name => "Dealul Piscului 1933";
        public long Srid => 4316;

        public string OgcWkt =>
            "GEOGCS[Dealul Piscului 1933,DATUM[Dealul_Piscului_1933,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6316]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4316]]";

        public string EsriWkt =>
            "GEOGCS[Dealul Piscului 1933,DATUM[Dealul_Piscului_1933,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6316]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4316]]";
    }
}
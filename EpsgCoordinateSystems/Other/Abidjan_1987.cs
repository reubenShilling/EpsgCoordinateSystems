namespace EpsgCoordinateSystems.Other
{
    public class Abidjan_1987 : IEpsgCoordinateSystem
    {
        public string Name => "Abidjan 1987";
        public long Srid => 4143;

        public string OgcWkt =>
            "GEOGCS[Abidjan 1987,DATUM[Abidjan_1987,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-124.76,53,466.79,0,0,0,0],AUTHORITY[EPSG,6143]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4143]]";

        public string EsriWkt =>
            "GEOGCS[Abidjan 1987,DATUM[Abidjan_1987,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-124.76,53,466.79,0,0,0,0],AUTHORITY[EPSG,6143]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4143]]";
    }
}
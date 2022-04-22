namespace EpsgCoordinateSystems.Categories.Other
{
    public class Abidjan_1987 : IEpsgCoordinateSystem
    {
        public string Name => "Abidjan 1987";
        public string Units => "Unspecified";
public int Srid => 4143;

        public string OgcWkt =>
            "GEOGCS[Abidjan 1987,DATUM[Abidjan_1987,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-124.76,53,466.79,0,0,0,0],AUTHORITY[EPSG,6143]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4143]]";

        public string EsriWkt => "GEOGCS[Abidjan 1987,DATUM[D_Abidjan_1987,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
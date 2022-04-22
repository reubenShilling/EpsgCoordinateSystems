namespace EpsgCoordinateSystems.Other
{
    public class Jouik_1961 : IEpsgCoordinateSystem
    {
        public string Name => "Jouik 1961";
        public string Units => "Unspecified";
public long Srid => 4679;

        public string OgcWkt =>
            "GEOGCS[Jouik 1961,DATUM[Jouik_1961,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-80.01,253.26,291.19,0,0,0,0],AUTHORITY[EPSG,6679]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4679]]";

        public string EsriWkt =>
            "GEOGCS[Jouik 1961,DATUM[Jouik_1961,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-80.01,253.26,291.19,0,0,0,0],AUTHORITY[EPSG,6679]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4679]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Liberia_1964 : IEpsgCoordinateSystem
    {
        public string Name => "Liberia 1964";
        public long Srid => 4251;

        public string OgcWkt =>
            "GEOGCS[Liberia 1964,DATUM[Liberia_1964,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-90,40,88,0,0,0,0],AUTHORITY[EPSG,6251]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4251]]";

        public string EsriWkt =>
            "GEOGCS[Liberia 1964,DATUM[Liberia_1964,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-90,40,88,0,0,0,0],AUTHORITY[EPSG,6251]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4251]]";
    }
}
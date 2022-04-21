namespace EpsgCoordinateSystems.Other
{
    public class Camacupa : IEpsgCoordinateSystem
    {
        public string Name => "Camacupa";
        public long Srid => 4220;

        public string OgcWkt =>
            "GEOGCS[Camacupa,DATUM[Camacupa,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6220]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4220]]";

        public string EsriWkt =>
            "GEOGCS[Camacupa,DATUM[Camacupa,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6220]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4220]]";
    }
}
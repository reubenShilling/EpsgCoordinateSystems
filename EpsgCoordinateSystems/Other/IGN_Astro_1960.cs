namespace EpsgCoordinateSystems.Other
{
    public class IGN_Astro_1960 : IEpsgCoordinateSystem
    {
        public string Name => "IGN Astro 1960";
        public long Srid => 4700;

        public string OgcWkt =>
            "GEOGCS[IGN Astro 1960,DATUM[IGN_Astro_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6700]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4700]]";

        public string EsriWkt =>
            "GEOGCS[IGN Astro 1960,DATUM[IGN_Astro_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6700]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4700]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Ayabelle_Lighthouse : IEpsgCoordinateSystem
    {
        public string Name => "Ayabelle Lighthouse";
        public long Srid => 4713;

        public string OgcWkt =>
            "GEOGCS[Ayabelle Lighthouse,DATUM[Ayabelle_Lighthouse,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79,-129,145,0,0,0,0],AUTHORITY[EPSG,6713]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4713]]";

        public string EsriWkt =>
            "GEOGCS[Ayabelle Lighthouse,DATUM[Ayabelle_Lighthouse,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79,-129,145,0,0,0,0],AUTHORITY[EPSG,6713]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4713]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class KOC : IEpsgCoordinateSystem
    {
        public string Name => "KOC";
        public long Srid => 4246;

        public string OgcWkt =>
            "GEOGCS[KOC,DATUM[Kuwait_Oil_Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0,0,0,0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4246]]";

        public string EsriWkt =>
            "GEOGCS[KOC,DATUM[Kuwait_Oil_Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0,0,0,0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4246]]";
    }
}
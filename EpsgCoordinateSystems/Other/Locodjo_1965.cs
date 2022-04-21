namespace EpsgCoordinateSystems.Other
{
    public class Locodjo_1965 : IEpsgCoordinateSystem
    {
        public string Name => "Locodjo 1965";
        public long Srid => 4142;

        public string OgcWkt =>
            "GEOGCS[Locodjo 1965,DATUM[Locodjo_1965,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-125,53,467,0,0,0,0],AUTHORITY[EPSG,6142]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4142]]";

        public string EsriWkt =>
            "GEOGCS[Locodjo 1965,DATUM[Locodjo_1965,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-125,53,467,0,0,0,0],AUTHORITY[EPSG,6142]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4142]]";
    }
}
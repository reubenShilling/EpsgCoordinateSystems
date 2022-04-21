namespace EpsgCoordinateSystems.Other
{
    public class Montserrat_1958 : IEpsgCoordinateSystem
    {
        public string Name => "Montserrat 1958";
        public long Srid => 4604;

        public string OgcWkt =>
            "GEOGCS[Montserrat 1958,DATUM[Montserrat_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[174,359,365,0,0,0,0],AUTHORITY[EPSG,6604]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4604]]";

        public string EsriWkt =>
            "GEOGCS[Montserrat 1958,DATUM[Montserrat_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[174,359,365,0,0,0,0],AUTHORITY[EPSG,6604]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4604]]";
    }
}
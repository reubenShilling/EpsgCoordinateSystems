namespace EpsgCoordinateSystems.Other
{
    public class Barbados_1938 : IEpsgCoordinateSystem
    {
        public string Name => "Barbados 1938";
        public string Units => "Unspecified";
public long Srid => 4212;

        public string OgcWkt =>
            "GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]]";

        public string EsriWkt =>
            "GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]]";
    }
}
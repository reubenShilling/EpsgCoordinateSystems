namespace EpsgCoordinateSystems.Other
{
    public class Antigua_1943 : IEpsgCoordinateSystem
    {
        public string Name => "Antigua 1943";
        public string Units => "Unspecified";
public long Srid => 4601;

        public string OgcWkt =>
            "GEOGCS[Antigua 1943,DATUM[Antigua_1943,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6601]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4601]]";

        public string EsriWkt =>
            "GEOGCS[Antigua 1943,DATUM[Antigua_1943,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6601]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4601]]";
    }
}
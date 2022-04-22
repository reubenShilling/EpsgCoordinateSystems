namespace EpsgCoordinateSystems.Other
{
    public class Nahrwan_1934 : IEpsgCoordinateSystem
    {
        public string Name => "Nahrwan 1934";
        public string Units => "Unspecified";
public long Srid => 4744;

        public string OgcWkt =>
            "GEOGCS[Nahrwan 1934,DATUM[Nahrwan_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6744]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4744]]";

        public string EsriWkt =>
            "GEOGCS[Nahrwan 1934,DATUM[Nahrwan_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6744]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4744]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Lome : IEpsgCoordinateSystem
    {
        public string Name => "Lome";
        public long Srid => 4252;

        public string OgcWkt =>
            "GEOGCS[Lome,DATUM[Lome,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6252]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4252]]";

        public string EsriWkt =>
            "GEOGCS[Lome,DATUM[Lome,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6252]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4252]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Agadez : IEpsgCoordinateSystem
    {
        public string Name => "Agadez";
        public string Units => "Unspecified";
public long Srid => 4206;

        public string OgcWkt =>
            "GEOGCS[Agadez,DATUM[Agadez,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6206]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4206]]";

        public string EsriWkt =>
            "GEOGCS[Agadez,DATUM[Agadez,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6206]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4206]]";
    }
}
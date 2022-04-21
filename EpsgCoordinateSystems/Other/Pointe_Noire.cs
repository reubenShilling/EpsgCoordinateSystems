namespace EpsgCoordinateSystems.Other
{
    public class Pointe_Noire : IEpsgCoordinateSystem
    {
        public string Name => "Pointe Noire";
        public long Srid => 4282;

        public string OgcWkt =>
            "GEOGCS[Pointe Noire,DATUM[Congo_1960_Pointe_Noire,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6282]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4282]]";

        public string EsriWkt =>
            "GEOGCS[Pointe Noire,DATUM[Congo_1960_Pointe_Noire,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6282]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4282]]";
    }
}
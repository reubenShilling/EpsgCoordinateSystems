namespace EpsgCoordinateSystems.Other
{
    public class Tete : IEpsgCoordinateSystem
    {
        public string Name => "Tete";
        public long Srid => 4127;

        public string OgcWkt =>
            "GEOGCS[Tete,DATUM[Tete,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6127]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4127]]";

        public string EsriWkt =>
            "GEOGCS[Tete,DATUM[Tete,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6127]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4127]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Bermuda_1957 : IEpsgCoordinateSystem
    {
        public string Name => "Bermuda 1957";
        public long Srid => 4216;

        public string OgcWkt =>
            "GEOGCS[Bermuda 1957,DATUM[Bermuda_1957,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6216]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4216]]";

        public string EsriWkt =>
            "GEOGCS[Bermuda 1957,DATUM[Bermuda_1957,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6216]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4216]]";
    }
}
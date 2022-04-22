namespace EpsgCoordinateSystems.Other
{
    public class Madzansua : IEpsgCoordinateSystem
    {
        public string Name => "Madzansua";
        public string Units => "Unspecified";
public long Srid => 4128;

        public string OgcWkt =>
            "GEOGCS[Madzansua,DATUM[Madzansua,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6128]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4128]]";

        public string EsriWkt =>
            "GEOGCS[Madzansua,DATUM[Madzansua,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6128]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4128]]";
    }
}
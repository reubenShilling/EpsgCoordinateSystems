namespace EpsgCoordinateSystems.Categories.Other
{
    public class Madzansua : IEpsgCoordinateSystem
    {
        public string Name => "Madzansua";
        public string Units => "Unspecified";
public int Srid => 4128;

        public string OgcWkt =>
            "GEOGCS[Madzansua,DATUM[Madzansua,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6128]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4128]]";

        public string EsriWkt => "GEOGCS[Madzansua,DATUM[D_Madzansua,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
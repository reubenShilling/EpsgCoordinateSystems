namespace EpsgCoordinateSystems.Categories.Other
{
    public class Observatario : IEpsgCoordinateSystem
    {
        public string Name => "Observatario";
        public string Units => "Unspecified";
public int Srid => 4129;

        public string OgcWkt =>
            "GEOGCS[Observatario,DATUM[Observatario,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6129]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4129]]";

        public string EsriWkt => "GEOGCS[Observatario,DATUM[D_Observatario,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
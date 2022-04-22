namespace EpsgCoordinateSystems.Categories.Other
{
    public class Katanga_1955 : IEpsgCoordinateSystem
    {
        public string Name => "Katanga 1955";
        public string Units => "Unspecified";
public int Srid => 4695;

        public string OgcWkt =>
            "GEOGCS[Katanga 1955,DATUM[Katanga_1955,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6695]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4695]]";

        public string EsriWkt => "GEOGCS[Katanga 1955,DATUM[D_Katanga_1955,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
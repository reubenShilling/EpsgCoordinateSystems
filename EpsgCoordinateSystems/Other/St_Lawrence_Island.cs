namespace EpsgCoordinateSystems.Other
{
    public class St_Lawrence_Island : IEpsgCoordinateSystem
    {
        public string Name => "St. Lawrence Island";
        public string Units => "Unspecified";
public long Srid => 4136;

        public string OgcWkt =>
            "GEOGCS[St. Lawrence Island,DATUM[St_Lawrence_Island,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6136]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4136]]";

        public string EsriWkt =>
            "GEOGCS[St. Lawrence Island,DATUM[St_Lawrence_Island,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6136]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4136]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class St_George_Island : IEpsgCoordinateSystem
    {
        public string Name => "St. George Island";
        public string Units => "Unspecified";
public long Srid => 4138;

        public string OgcWkt =>
            "GEOGCS[St. George Island,DATUM[St_George_Island,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6138]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4138]]";

        public string EsriWkt => "GEOGCS[St. George Island,DATUM[D_St_George_Island,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
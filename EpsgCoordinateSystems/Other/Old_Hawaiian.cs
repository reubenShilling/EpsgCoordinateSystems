namespace EpsgCoordinateSystems.Other
{
    public class Old_Hawaiian : IEpsgCoordinateSystem
    {
        public string Name => "Old Hawaiian";
        public string Units => "Unspecified";
public long Srid => 4135;

        public string OgcWkt =>
            "GEOGCS[Old Hawaiian,DATUM[Old_Hawaiian,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6135]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4135]]";

        public string EsriWkt => "GEOGCS[Old Hawaiian,DATUM[D_Old_Hawaiian,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
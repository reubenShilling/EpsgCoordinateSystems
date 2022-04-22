namespace EpsgCoordinateSystems.Other
{
    public class JAD69 : IEpsgCoordinateSystem
    {
        public string Name => "JAD69";
        public string Units => "Unspecified";
public long Srid => 4242;

        public string OgcWkt =>
            "GEOGCS[JAD69,DATUM[Jamaica_1969,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6242]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4242]]";

        public string EsriWkt => "GEOGCS[JAD69,DATUM[D_Jamaica_1969,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
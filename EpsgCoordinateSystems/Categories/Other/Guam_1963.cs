namespace EpsgCoordinateSystems.Categories.Other
{
    public class Guam_1963 : IEpsgCoordinateSystem
    {
        public string Name => "Guam 1963";
        public string Units => "Unspecified";
public int Srid => 4675;

        public string OgcWkt =>
            "GEOGCS[Guam 1963,DATUM[Guam_1963,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-100,-248,259,0,0,0,0],AUTHORITY[EPSG,6675]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4675]]";

        public string EsriWkt => "GEOGCS[Guam 1963,DATUM[D_Guam_1963,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
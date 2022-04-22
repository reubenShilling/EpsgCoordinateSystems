namespace EpsgCoordinateSystems.Categories.Other
{
    public class American_Samoa_1962 : IEpsgCoordinateSystem
    {
        public string Name => "American Samoa 1962";
        public string Units => "Unspecified";
public int Srid => 4169;

        public string OgcWkt =>
            "GEOGCS[American Samoa 1962,DATUM[American_Samoa_1962,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-115,118,426,0,0,0,0],AUTHORITY[EPSG,6169]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4169]]";

        public string EsriWkt => "GEOGCS[American Samoa 1962,DATUM[D_American_Samoa_1962,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
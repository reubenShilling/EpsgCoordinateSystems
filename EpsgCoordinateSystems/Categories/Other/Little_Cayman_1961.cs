namespace EpsgCoordinateSystems.Categories.Other
{
    public class Little_Cayman_1961 : IEpsgCoordinateSystem
    {
        public string Name => "Little Cayman 1961";
        public string Units => "Unspecified";
public int Srid => 4726;

        public string OgcWkt =>
            "GEOGCS[Little Cayman 1961,DATUM[Little_Cayman_1961,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6726]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4726]]";

        public string EsriWkt => "GEOGCS[Little Cayman 1961,DATUM[D_Little_Cayman_1961,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
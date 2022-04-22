namespace EpsgCoordinateSystems.Categories.Other
{
    public class Accra : IEpsgCoordinateSystem
    {
        public string Name => "Accra";
        public string Units => "Unspecified";
public int Srid => 4168;

        public string OgcWkt =>
            "GEOGCS[Accra,DATUM[Accra,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],TOWGS84[-199,32,322,0,0,0,0],AUTHORITY[EPSG,6168]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4168]]";

        public string EsriWkt => "GEOGCS[Accra,DATUM[D_Accra,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_War_Office_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the War Office ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4029;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the War Office ellipsoid,DATUM[Not_specified_based_on_War_Office_ellipsoid,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],AUTHORITY[EPSG,6029]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4029]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the War Office ellipsoid,DATUM[D_War_Office,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
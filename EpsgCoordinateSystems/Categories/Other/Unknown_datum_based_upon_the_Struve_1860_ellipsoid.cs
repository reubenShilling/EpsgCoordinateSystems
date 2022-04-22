namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Struve_1860_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Struve 1860 ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4028;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Struve 1860 ellipsoid,DATUM[Not_specified_based_on_Struve_1860_ellipsoid,SPHEROID[Struve 1860,6378298.3,294.73,AUTHORITY[EPSG,7028]],AUTHORITY[EPSG,6028]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4028]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Struve 1860 ellipsoid,DATUM[D_Struve_1860,SPHEROID[Struve_1860,6378298.3,294.73]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
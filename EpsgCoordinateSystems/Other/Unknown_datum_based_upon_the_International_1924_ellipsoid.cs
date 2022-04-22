namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_International_1924_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the International 1924 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4022;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the International 1924 ellipsoid,DATUM[Not_specified_based_on_International_1924_ellipsoid,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6022]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4022]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the International 1924 ellipsoid,DATUM[Not_specified_based_on_International_1924_ellipsoid,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6022]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4022]]";
    }
}
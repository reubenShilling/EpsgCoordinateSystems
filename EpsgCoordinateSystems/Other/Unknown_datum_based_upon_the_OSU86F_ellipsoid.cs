namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_OSU86F_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the OSU86F ellipsoid";
        public long Srid => 4032;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the OSU86F ellipsoid,DATUM[Not_specified_based_on_OSU86F_ellipsoid,SPHEROID[OSU86F,6378136.2,298.257223563,AUTHORITY[EPSG,7032]],AUTHORITY[EPSG,6032]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4032]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the OSU86F ellipsoid,DATUM[Not_specified_based_on_OSU86F_ellipsoid,SPHEROID[OSU86F,6378136.2,298.257223563,AUTHORITY[EPSG,7032]],AUTHORITY[EPSG,6032]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4032]]";
    }
}
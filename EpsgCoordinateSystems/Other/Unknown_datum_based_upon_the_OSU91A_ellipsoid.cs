namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_OSU91A_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the OSU91A ellipsoid";
        public long Srid => 4033;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the OSU91A ellipsoid,DATUM[Not_specified_based_on_OSU91A_ellipsoid,SPHEROID[OSU91A,6378136.3,298.257223563,AUTHORITY[EPSG,7033]],AUTHORITY[EPSG,6033]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4033]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the OSU91A ellipsoid,DATUM[Not_specified_based_on_OSU91A_ellipsoid,SPHEROID[OSU91A,6378136.3,298.257223563,AUTHORITY[EPSG,7033]],AUTHORITY[EPSG,6033]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4033]]";
    }
}
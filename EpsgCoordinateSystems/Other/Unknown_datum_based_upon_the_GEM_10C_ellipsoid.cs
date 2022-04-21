namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_GEM_10C_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the GEM 10C ellipsoid";
        public long Srid => 4031;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the GEM 10C ellipsoid,DATUM[Not_specified_based_on_GEM_10C_ellipsoid,SPHEROID[GEM 10C,6378137,298.257223563,AUTHORITY[EPSG,7031]],AUTHORITY[EPSG,6031]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4031]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the GEM 10C ellipsoid,DATUM[Not_specified_based_on_GEM_10C_ellipsoid,SPHEROID[GEM 10C,6378137,298.257223563,AUTHORITY[EPSG,7031]],AUTHORITY[EPSG,6031]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4031]]";
    }
}
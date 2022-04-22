namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_GRS_1980_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the GRS 1980 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4019;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the GRS 1980 ellipsoid,DATUM[Not_specified_based_on_GRS_1980_ellipsoid,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6019]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4019]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the GRS 1980 ellipsoid,DATUM[Not_specified_based_on_GRS_1980_ellipsoid,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6019]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4019]]";
    }
}
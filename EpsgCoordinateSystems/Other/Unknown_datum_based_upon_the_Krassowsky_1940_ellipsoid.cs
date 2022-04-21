namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Krassowsky_1940_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Krassowsky 1940 ellipsoid";
        public long Srid => 4024;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Krassowsky 1940 ellipsoid,DATUM[Not_specified_based_on_Krassowsky_1940_ellipsoid,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6024]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4024]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Krassowsky 1940 ellipsoid,DATUM[Not_specified_based_on_Krassowsky_1940_ellipsoid,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6024]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4024]]";
    }
}
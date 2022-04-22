namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Bessel_Modified_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Bessel Modified ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4005;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Bessel Modified ellipsoid,DATUM[Not_specified_based_on_Bessel_Modified_ellipsoid,SPHEROID[Bessel Modified,6377492.018,299.1528128,AUTHORITY[EPSG,7005]],AUTHORITY[EPSG,6005]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4005]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Bessel Modified ellipsoid,DATUM[Not_specified_based_on_Bessel_Modified_ellipsoid,SPHEROID[Bessel Modified,6377492.018,299.1528128,AUTHORITY[EPSG,7005]],AUTHORITY[EPSG,6005]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4005]]";
    }
}
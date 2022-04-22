namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Airy_Modified_1849_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Airy Modified 1849 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4002;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Airy Modified 1849 ellipsoid,DATUM[Not_specified_based_on_Airy_Modified_1849_ellipsoid,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6002]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4002]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Airy Modified 1849 ellipsoid,DATUM[Not_specified_based_on_Airy_Modified_1849_ellipsoid,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6002]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4002]]";
    }
}
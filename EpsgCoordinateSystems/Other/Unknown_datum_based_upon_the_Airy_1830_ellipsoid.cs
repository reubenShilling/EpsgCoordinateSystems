namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Airy_1830_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Airy 1830 ellipsoid";
        public long Srid => 4001;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Airy 1830 ellipsoid,DATUM[Not_specified_based_on_Airy_1830_ellipsoid,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6001]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4001]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Airy 1830 ellipsoid,DATUM[Not_specified_based_on_Airy_1830_ellipsoid,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6001]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4001]]";
    }
}
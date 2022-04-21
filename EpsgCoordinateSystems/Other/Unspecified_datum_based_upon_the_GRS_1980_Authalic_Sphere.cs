namespace EpsgCoordinateSystems.Other
{
    public class Unspecified_datum_based_upon_the_GRS_1980_Authalic_Sphere : IEpsgCoordinateSystem
    {
        public string Name => "Unspecified datum based upon the GRS 1980 Authalic Sphere";
        public long Srid => 4047;

        public string OgcWkt =>
            "GEOGCS[Unspecified datum based upon the GRS 1980 Authalic Sphere,DATUM[Not_specified_based_on_GRS_1980_Authalic_Sphere,SPHEROID[GRS 1980 Authalic Sphere,6371007,0,AUTHORITY[EPSG,7048]],AUTHORITY[EPSG,6047]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4047]]";

        public string EsriWkt =>
            "GEOGCS[Unspecified datum based upon the GRS 1980 Authalic Sphere,DATUM[Not_specified_based_on_GRS_1980_Authalic_Sphere,SPHEROID[GRS 1980 Authalic Sphere,6371007,0,AUTHORITY[EPSG,7048]],AUTHORITY[EPSG,6047]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4047]]";
    }
}
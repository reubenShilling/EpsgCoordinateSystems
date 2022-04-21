namespace EpsgCoordinateSystems.Other
{
    public class Unspecified_datum_based_upon_the_International_1924_Authalic_Sphere : IEpsgCoordinateSystem
    {
        public string Name => "Unspecified datum based upon the International 1924 Authalic Sphere";
        public long Srid => 4053;

        public string OgcWkt =>
            "GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]]";

        public string EsriWkt =>
            "GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]]";
    }
}
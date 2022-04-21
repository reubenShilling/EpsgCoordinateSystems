namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Australian_National_Spheroid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Australian National Spheroid";
        public long Srid => 4003;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Australian National Spheroid,DATUM[Not_specified_based_on_Australian_National_Spheroid,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6003]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4003]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Australian National Spheroid,DATUM[Not_specified_based_on_Australian_National_Spheroid,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6003]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4003]]";
    }
}
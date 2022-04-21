namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Indonesian_National_Spheroid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Indonesian National Spheroid";
        public long Srid => 4021;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Indonesian National Spheroid,DATUM[Not_specified_based_on_Indonesian_National_Spheroid,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6021]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4021]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Indonesian National Spheroid,DATUM[Not_specified_based_on_Indonesian_National_Spheroid,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6021]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4021]]";
    }
}
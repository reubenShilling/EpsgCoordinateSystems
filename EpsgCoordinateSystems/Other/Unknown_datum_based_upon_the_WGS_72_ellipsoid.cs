namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_WGS_72_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the WGS 72 ellipsoid";
        public long Srid => 4043;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the WGS 72 ellipsoid,DATUM[Not_specified_based_on_WGS_72_ellipsoid,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6043]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4043]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the WGS 72 ellipsoid,DATUM[Not_specified_based_on_WGS_72_ellipsoid,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6043]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4043]]";
    }
}
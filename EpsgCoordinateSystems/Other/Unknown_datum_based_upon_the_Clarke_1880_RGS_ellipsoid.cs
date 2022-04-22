namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_RGS_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1880 (RGS) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4012;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (RGS) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_RGS_ellipsoid,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6012]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4012]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (RGS) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_RGS_ellipsoid,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6012]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4012]]";
    }
}
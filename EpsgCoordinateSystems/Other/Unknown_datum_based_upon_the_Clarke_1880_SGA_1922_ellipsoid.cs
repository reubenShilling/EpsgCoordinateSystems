namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_SGA_1922_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1880 (SGA 1922) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4014;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (SGA 1922) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_SGA_1922_ellipsoid,SPHEROID[Clarke 1880 (SGA 1922),6378249.2,293.46598,AUTHORITY[EPSG,7014]],AUTHORITY[EPSG,6014]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4014]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (SGA 1922) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_SGA_1922_ellipsoid,SPHEROID[Clarke 1880 (SGA 1922),6378249.2,293.46598,AUTHORITY[EPSG,7014]],AUTHORITY[EPSG,6014]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4014]]";
    }
}
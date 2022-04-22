namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_Benoit_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1880 (Benoit) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4010;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (Benoit) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_Benoit_ellipsoid,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],AUTHORITY[EPSG,6010]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4010]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (Benoit) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_Benoit_ellipsoid,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],AUTHORITY[EPSG,6010]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4010]]";
    }
}
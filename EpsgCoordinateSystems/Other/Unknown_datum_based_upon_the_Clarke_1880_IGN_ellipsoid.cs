namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_IGN_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1880 (IGN) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4011;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (IGN) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_IGN_ellipsoid,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6011]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4011]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Clarke 1880 (IGN) ellipsoid,DATUM[D_Clarke_1880_IGN,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1866_Michigan_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1866 Michigan ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4009;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1866 Michigan ellipsoid,DATUM[Not_specified_based_on_Clarke_1866_Michigan_ellipsoid,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6009]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4009]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1866 Michigan ellipsoid,DATUM[Not_specified_based_on_Clarke_1866_Michigan_ellipsoid,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6009]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4009]]";
    }
}
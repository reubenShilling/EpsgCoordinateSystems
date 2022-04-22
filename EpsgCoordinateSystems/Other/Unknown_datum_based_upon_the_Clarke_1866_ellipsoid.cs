namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1866_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1866 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4008;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1866 ellipsoid,DATUM[Not_specified_based_on_Clarke_1866_ellipsoid,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6008]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4008]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Clarke 1866 ellipsoid,DATUM[D_Clarke_1866,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
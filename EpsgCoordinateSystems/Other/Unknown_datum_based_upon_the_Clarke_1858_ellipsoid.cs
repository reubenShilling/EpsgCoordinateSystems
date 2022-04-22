namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1858_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Clarke 1858 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4007;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1858 ellipsoid,DATUM[Not_specified_based_on_Clarke_1858_ellipsoid,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6007]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4007]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Clarke 1858 ellipsoid,DATUM[D_Clarke_1858,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
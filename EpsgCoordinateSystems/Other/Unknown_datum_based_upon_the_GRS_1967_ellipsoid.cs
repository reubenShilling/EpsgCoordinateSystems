namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_GRS_1967_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the GRS 1967 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4036;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the GRS 1967 ellipsoid,DATUM[Not_specified_based_on_GRS_1967_ellipsoid,SPHEROID[GRS 1967,6378160,298.247167427,AUTHORITY[EPSG,7036]],AUTHORITY[EPSG,6036]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4036]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the GRS 1967 ellipsoid,DATUM[D_GRS_1967,SPHEROID[GRS_1967,6378160,298.247167427]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
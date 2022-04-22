namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_WGS_84_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the WGS 84 ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4030;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the WGS 84 ellipsoid,DATUM[Not_specified_based_on_WGS_84_ellipsoid,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6030]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4030]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the WGS 84 ellipsoid,DATUM[D_,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_NWL_9D_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the NWL 9D ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4025;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the NWL 9D ellipsoid,DATUM[Not_specified_based_on_NWL_9D_ellipsoid,SPHEROID[NWL 9D,6378145,298.25,AUTHORITY[EPSG,7025]],AUTHORITY[EPSG,6025]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4025]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the NWL 9D ellipsoid,DATUM[D_NWL_9D,SPHEROID[NWL_9D,6378145,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
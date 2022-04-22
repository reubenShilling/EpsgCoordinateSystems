namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Everest_1830_Definition_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Everest (1830 Definition) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4042;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Everest (1830 Definition) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_Definition_ellipsoid,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6042]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4042]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Everest (1830 Definition) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_Definition_ellipsoid,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6042]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4042]]";
    }
}
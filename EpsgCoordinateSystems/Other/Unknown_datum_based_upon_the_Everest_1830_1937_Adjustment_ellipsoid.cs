namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Everest_1830_1937_Adjustment_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Everest 1830 (1937 Adjustment) ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4015;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Everest 1830 (1937 Adjustment) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_1937_Adjustment_ellipsoid,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6015]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4015]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Everest 1830 (1937 Adjustment) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_1937_Adjustment_ellipsoid,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6015]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4015]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Everest_1830_1967_Definition_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Everest 1830 (1967 Definition) ellipsoid";
        public long Srid => 4016;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Everest 1830 (1967 Definition) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_1967_Definition_ellipsoid,SPHEROID[Everest 1830 (1967 Definition),6377298.556,300.8017,AUTHORITY[EPSG,7016]],AUTHORITY[EPSG,6016]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4016]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Everest 1830 (1967 Definition) ellipsoid,DATUM[Not_specified_based_on_Everest_1830_1967_Definition_ellipsoid,SPHEROID[Everest 1830 (1967 Definition),6377298.556,300.8017,AUTHORITY[EPSG,7016]],AUTHORITY[EPSG,6016]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4016]]";
    }
}
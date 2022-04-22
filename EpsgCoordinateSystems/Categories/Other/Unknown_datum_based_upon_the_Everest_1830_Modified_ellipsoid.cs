namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Everest_1830_Modified_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Everest 1830 Modified ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4018;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Everest 1830 Modified ellipsoid,DATUM[Not_specified_based_on_Everest_1830_Modified_ellipsoid,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],AUTHORITY[EPSG,6018]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4018]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Everest 1830 Modified ellipsoid,DATUM[D_Everest_Modified,SPHEROID[Everest_1830_Modified,6377304.063,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
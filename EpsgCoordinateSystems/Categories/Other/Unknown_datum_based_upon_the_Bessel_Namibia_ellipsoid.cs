namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Bessel_Namibia_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Bessel Namibia ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4006;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Bessel Namibia ellipsoid,DATUM[Not_specified_based_on_Bessel_Namibia_ellipsoid,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6006]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4006]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Bessel Namibia ellipsoid,DATUM[D_Bessel_Namibia,SPHEROID[Bessel_Namibia_GLM,6377483.865280419,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
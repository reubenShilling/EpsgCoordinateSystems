namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Helmert_1906_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Helmert 1906 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4020;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Helmert 1906 ellipsoid,DATUM[Not_specified_based_on_Helmert_1906_ellipsoid,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6020]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4020]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Helmert 1906 ellipsoid,DATUM[D_Helmert_1906,SPHEROID[Helmert_1906,6378200,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
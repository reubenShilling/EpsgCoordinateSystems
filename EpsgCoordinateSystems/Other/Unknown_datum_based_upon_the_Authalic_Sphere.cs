namespace EpsgCoordinateSystems.Other
{
    public class Unknown_datum_based_upon_the_Authalic_Sphere : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Authalic Sphere";
        public string Units => "Unspecified";
public long Srid => 4035;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Authalic Sphere,DATUM[Not_specified_based_on_Authalic_Sphere,SPHEROID[Sphere,6371000,0,AUTHORITY[EPSG,7035]],AUTHORITY[EPSG,6035]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4035]]";

        public string EsriWkt =>
            "GEOGCS[Unknown datum based upon the Authalic Sphere,DATUM[Not_specified_based_on_Authalic_Sphere,SPHEROID[Sphere,6371000,0,AUTHORITY[EPSG,7035]],AUTHORITY[EPSG,6035]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4035]]";
    }
}
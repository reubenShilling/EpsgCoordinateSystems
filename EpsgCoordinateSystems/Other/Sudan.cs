namespace EpsgCoordinateSystems.Other
{
    public class Sudan : IEpsgCoordinateSystem
    {
        public string Name => "Sudan";
        public long Srid => 4296;

        public string OgcWkt =>
            "GEOGCS[Sudan,DATUM[Sudan,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6296]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4296]]";

        public string EsriWkt =>
            "GEOGCS[Sudan,DATUM[Sudan,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6296]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4296]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class POSGAR : IEpsgCoordinateSystem
    {
        public string Name => "POSGAR";
        public long Srid => 4172;

        public string OgcWkt =>
            "GEOGCS[POSGAR,DATUM[Posiciones_Geodesicas_Argentinas,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6172]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4172]]";

        public string EsriWkt =>
            "GEOGCS[POSGAR,DATUM[Posiciones_Geodesicas_Argentinas,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6172]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4172]]";
    }
}
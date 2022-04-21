namespace EpsgCoordinateSystems.Other
{
    public class IGN72_Grand_Terre : IEpsgCoordinateSystem
    {
        public string Name => "IGN72 Grand Terre";
        public long Srid => 4634;

        public string OgcWkt =>
            "GEOGCS[IGN72 Grand Terre,DATUM[IGN72_Grande_Terre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6634]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4634]]";

        public string EsriWkt =>
            "GEOGCS[IGN72 Grand Terre,DATUM[IGN72_Grande_Terre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6634]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4634]]";
    }
}
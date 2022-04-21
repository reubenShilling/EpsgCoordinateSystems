namespace EpsgCoordinateSystems.Other
{
    public class Guyane_Francaise : IEpsgCoordinateSystem
    {
        public string Name => "Guyane Francaise";
        public long Srid => 4235;

        public string OgcWkt =>
            "GEOGCS[Guyane Francaise,DATUM[Guyane_Francaise,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6235]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4235]]";

        public string EsriWkt =>
            "GEOGCS[Guyane Francaise,DATUM[Guyane_Francaise,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6235]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4235]]";
    }
}
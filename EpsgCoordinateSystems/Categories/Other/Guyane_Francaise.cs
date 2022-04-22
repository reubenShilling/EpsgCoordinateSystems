namespace EpsgCoordinateSystems.Categories.Other
{
    public class Guyane_Francaise : IEpsgCoordinateSystem
    {
        public string Name => "Guyane Francaise";
        public string Units => "Unspecified";
public int Srid => 4235;

        public string OgcWkt =>
            "GEOGCS[Guyane Francaise,DATUM[Guyane_Francaise,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6235]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4235]]";

        public string EsriWkt => "GEOGCS[Guyane Francaise,DATUM[D_Guyane_Francaise,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
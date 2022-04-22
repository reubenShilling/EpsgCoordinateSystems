namespace EpsgCoordinateSystems.Categories.Other
{
    public class Madeira_1936 : IEpsgCoordinateSystem
    {
        public string Name => "Madeira 1936";
        public string Units => "Unspecified";
public int Srid => 4185;

        public string OgcWkt =>
            "GEOGCS[Madeira 1936,DATUM[Madeira_1936,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6185]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4185]]";

        public string EsriWkt => "GEOGCS[Madeira 1936,DATUM[D_Madeira_1936,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
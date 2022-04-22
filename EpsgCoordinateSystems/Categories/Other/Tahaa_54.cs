namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tahaa_54 : IEpsgCoordinateSystem
    {
        public string Name => "Tahaa 54";
        public string Units => "Unspecified";
public int Srid => 4629;

        public string OgcWkt =>
            "GEOGCS[Tahaa 54,DATUM[Tahaa_54,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6629]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4629]]";

        public string EsriWkt => "GEOGCS[Tahaa 54,DATUM[D_Tahaa_1954,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
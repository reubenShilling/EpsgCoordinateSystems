namespace EpsgCoordinateSystems.Categories.Other
{
    public class Gan_1970 : IEpsgCoordinateSystem
    {
        public string Name => "Gan 1970";
        public string Units => "Unspecified";
public int Srid => 4684;

        public string OgcWkt =>
            "GEOGCS[Gan 1970,DATUM[Gan_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133,-321,50,0,0,0,0],AUTHORITY[EPSG,6684]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4684]]";

        public string EsriWkt => "GEOGCS[Gan 1970,DATUM[D_Gan_1970,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
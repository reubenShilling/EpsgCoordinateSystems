namespace EpsgCoordinateSystems.Other
{
    public class Gan_1970 : IEpsgCoordinateSystem
    {
        public string Name => "Gan 1970";
        public long Srid => 4684;

        public string OgcWkt =>
            "GEOGCS[Gan 1970,DATUM[Gan_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133,-321,50,0,0,0,0],AUTHORITY[EPSG,6684]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4684]]";

        public string EsriWkt =>
            "GEOGCS[Gan 1970,DATUM[Gan_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133,-321,50,0,0,0,0],AUTHORITY[EPSG,6684]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4684]]";
    }
}
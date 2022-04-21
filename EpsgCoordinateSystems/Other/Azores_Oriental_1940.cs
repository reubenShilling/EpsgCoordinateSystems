namespace EpsgCoordinateSystems.Other
{
    public class Azores_Oriental_1940 : IEpsgCoordinateSystem
    {
        public string Name => "Azores Oriental 1940";
        public long Srid => 4184;

        public string OgcWkt =>
            "GEOGCS[Azores Oriental 1940,DATUM[Azores_Oriental_Islands_1940,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-203,141,53,0,0,0,0],AUTHORITY[EPSG,6184]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4184]]";

        public string EsriWkt =>
            "GEOGCS[Azores Oriental 1940,DATUM[Azores_Oriental_Islands_1940,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-203,141,53,0,0,0,0],AUTHORITY[EPSG,6184]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4184]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class St_Helena_1971 : IEpsgCoordinateSystem
    {
        public string Name => "St. Helena 1971";
        public long Srid => 4710;

        public string OgcWkt =>
            "GEOGCS[St. Helena 1971,DATUM[St_Helena_1971,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-320,550,-494,0,0,0,0],AUTHORITY[EPSG,6710]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4710]]";

        public string EsriWkt =>
            "GEOGCS[St. Helena 1971,DATUM[St_Helena_1971,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-320,550,-494,0,0,0,0],AUTHORITY[EPSG,6710]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4710]]";
    }
}
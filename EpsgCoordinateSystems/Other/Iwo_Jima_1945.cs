namespace EpsgCoordinateSystems.Other
{
    public class Iwo_Jima_1945 : IEpsgCoordinateSystem
    {
        public string Name => "Iwo Jima 1945";
        public long Srid => 4709;

        public string OgcWkt =>
            "GEOGCS[Iwo Jima 1945,DATUM[Iwo_Jima_1945,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,75,-272,0,0,0,0],AUTHORITY[EPSG,6709]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4709]]";

        public string EsriWkt =>
            "GEOGCS[Iwo Jima 1945,DATUM[Iwo_Jima_1945,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,75,-272,0,0,0,0],AUTHORITY[EPSG,6709]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4709]]";
    }
}
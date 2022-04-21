namespace EpsgCoordinateSystems.Other
{
    public class Hu_Tzu_Shan : IEpsgCoordinateSystem
    {
        public string Name => "Hu Tzu Shan";
        public long Srid => 4236;

        public string OgcWkt =>
            "GEOGCS[Hu Tzu Shan,DATUM[Hu_Tzu_Shan,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-637,-549,-203,0,0,0,0],AUTHORITY[EPSG,6236]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4236]]";

        public string EsriWkt =>
            "GEOGCS[Hu Tzu Shan,DATUM[Hu_Tzu_Shan,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-637,-549,-203,0,0,0,0],AUTHORITY[EPSG,6236]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4236]]";
    }
}
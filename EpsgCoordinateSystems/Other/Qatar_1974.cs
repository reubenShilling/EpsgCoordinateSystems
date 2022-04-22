namespace EpsgCoordinateSystems.Other
{
    public class Qatar_1974 : IEpsgCoordinateSystem
    {
        public string Name => "Qatar 1974";
        public string Units => "Unspecified";
public long Srid => 4285;

        public string OgcWkt =>
            "GEOGCS[Qatar 1974,DATUM[Qatar_1974,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6285]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4285]]";

        public string EsriWkt =>
            "GEOGCS[Qatar 1974,DATUM[Qatar_1974,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6285]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4285]]";
    }
}
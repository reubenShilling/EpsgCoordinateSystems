namespace EpsgCoordinateSystems.Other
{
    public class Gandajika : IEpsgCoordinateSystem
    {
        public string Name => "Gandajika";
        public long Srid => 4685;

        public string OgcWkt =>
            "GEOGCS[Gandajika,DATUM[Gandajika,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6685]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4685]]";

        public string EsriWkt =>
            "GEOGCS[Gandajika,DATUM[Gandajika,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6685]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4685]]";
    }
}
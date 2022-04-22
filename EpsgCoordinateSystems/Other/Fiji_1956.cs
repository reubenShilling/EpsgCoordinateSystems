namespace EpsgCoordinateSystems.Other
{
    public class Fiji_1956 : IEpsgCoordinateSystem
    {
        public string Name => "Fiji 1956";
        public string Units => "Unspecified";
public long Srid => 4721;

        public string OgcWkt =>
            "GEOGCS[Fiji 1956,DATUM[Fiji_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[265.025,384.929,-194.046,0,0,0,0],AUTHORITY[EPSG,6721]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4721]]";

        public string EsriWkt =>
            "GEOGCS[Fiji 1956,DATUM[Fiji_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[265.025,384.929,-194.046,0,0,0,0],AUTHORITY[EPSG,6721]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4721]]";
    }
}
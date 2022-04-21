namespace EpsgCoordinateSystems.Other
{
    public class Johnston_Island_1961 : IEpsgCoordinateSystem
    {
        public string Name => "Johnston Island 1961";
        public long Srid => 4725;

        public string OgcWkt =>
            "GEOGCS[Johnston Island 1961,DATUM[Johnston_Island_1961,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[189,-79,-202,0,0,0,0],AUTHORITY[EPSG,6725]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4725]]";

        public string EsriWkt =>
            "GEOGCS[Johnston Island 1961,DATUM[Johnston_Island_1961,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[189,-79,-202,0,0,0,0],AUTHORITY[EPSG,6725]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4725]]";
    }
}
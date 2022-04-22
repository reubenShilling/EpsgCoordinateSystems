namespace EpsgCoordinateSystems.Other
{
    public class Tahiti_52 : IEpsgCoordinateSystem
    {
        public string Name => "Tahiti 52";
        public string Units => "Unspecified";
public long Srid => 4628;

        public string OgcWkt =>
            "GEOGCS[Tahiti 52,DATUM[Tahiti_52,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[162,117,154,0,0,0,0],AUTHORITY[EPSG,6628]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4628]]";

        public string EsriWkt =>
            "GEOGCS[Tahiti 52,DATUM[Tahiti_52,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[162,117,154,0,0,0,0],AUTHORITY[EPSG,6628]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4628]]";
    }
}
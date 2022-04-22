namespace EpsgCoordinateSystems.Other
{
    public class Petrels_1972 : IEpsgCoordinateSystem
    {
        public string Name => "Petrels 1972";
        public string Units => "Unspecified";
public long Srid => 4636;

        public string OgcWkt =>
            "GEOGCS[Petrels 1972,DATUM[Petrels_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[365,194,166,0,0,0,0],AUTHORITY[EPSG,6636]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4636]]";

        public string EsriWkt =>
            "GEOGCS[Petrels 1972,DATUM[Petrels_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[365,194,166,0,0,0,0],AUTHORITY[EPSG,6636]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4636]]";
    }
}
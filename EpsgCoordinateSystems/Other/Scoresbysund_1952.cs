namespace EpsgCoordinateSystems.Other
{
    public class Scoresbysund_1952 : IEpsgCoordinateSystem
    {
        public string Name => "Scoresbysund 1952";
        public string Units => "Unspecified";
public long Srid => 4195;

        public string OgcWkt =>
            "GEOGCS[Scoresbysund 1952,DATUM[Scoresbysund_1952,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[105,326,-102.5,0,0,0.814,-0.6],AUTHORITY[EPSG,6195]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4195]]";

        public string EsriWkt =>
            "GEOGCS[Scoresbysund 1952,DATUM[Scoresbysund_1952,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[105,326,-102.5,0,0,0.814,-0.6],AUTHORITY[EPSG,6195]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4195]]";
    }
}
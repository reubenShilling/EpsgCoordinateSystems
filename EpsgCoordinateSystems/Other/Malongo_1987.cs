namespace EpsgCoordinateSystems.Other
{
    public class Malongo_1987 : IEpsgCoordinateSystem
    {
        public string Name => "Malongo 1987";
        public string Units => "Unspecified";
public long Srid => 4259;

        public string OgcWkt =>
            "GEOGCS[Malongo 1987,DATUM[Malongo_1987,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6259]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4259]]";

        public string EsriWkt =>
            "GEOGCS[Malongo 1987,DATUM[Malongo_1987,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6259]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4259]]";
    }
}
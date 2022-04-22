namespace EpsgCoordinateSystems.Other
{
    public class Tananarive : IEpsgCoordinateSystem
    {
        public string Name => "Tananarive";
        public string Units => "Unspecified";
public long Srid => 4297;

        public string OgcWkt =>
            "GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]]";

        public string EsriWkt =>
            "GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]]";
    }
}
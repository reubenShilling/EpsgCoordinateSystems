namespace EpsgCoordinateSystems.Other
{
    public class Herat_North : IEpsgCoordinateSystem
    {
        public string Name => "Herat North";
        public string Units => "Unspecified";
public long Srid => 4255;

        public string OgcWkt =>
            "GEOGCS[Herat North,DATUM[Herat_North,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-333,-222,114,0,0,0,0],AUTHORITY[EPSG,6255]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4255]]";

        public string EsriWkt =>
            "GEOGCS[Herat North,DATUM[Herat_North,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-333,-222,114,0,0,0,0],AUTHORITY[EPSG,6255]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4255]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Mhast : IEpsgCoordinateSystem
    {
        public string Name => "Mhast";
        public string Units => "Unspecified";
public long Srid => 4264;

        public string OgcWkt =>
            "GEOGCS[Mhast,DATUM[Mhast,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-252.95,-4.11,-96.38,0,0,0,0],AUTHORITY[EPSG,6264]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4264]]";

        public string EsriWkt =>
            "GEOGCS[Mhast,DATUM[Mhast,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-252.95,-4.11,-96.38,0,0,0,0],AUTHORITY[EPSG,6264]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4264]]";
    }
}
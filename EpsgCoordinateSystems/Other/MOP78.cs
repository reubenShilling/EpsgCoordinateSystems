namespace EpsgCoordinateSystems.Other
{
    public class MOP78 : IEpsgCoordinateSystem
    {
        public string Name => "MOP78";
        public string Units => "Unspecified";
public long Srid => 4639;

        public string OgcWkt =>
            "GEOGCS[MOP78,DATUM[MOP78,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6639]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4639]]";

        public string EsriWkt =>
            "GEOGCS[MOP78,DATUM[MOP78,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6639]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4639]]";
    }
}
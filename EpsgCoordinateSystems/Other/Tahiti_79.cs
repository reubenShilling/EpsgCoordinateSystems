namespace EpsgCoordinateSystems.Other
{
    public class Tahiti_79 : IEpsgCoordinateSystem
    {
        public string Name => "Tahiti 79";
        public string Units => "Unspecified";
public long Srid => 4690;

        public string OgcWkt =>
            "GEOGCS[Tahiti 79,DATUM[Tahiti_79,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6690]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4690]]";

        public string EsriWkt =>
            "GEOGCS[Tahiti 79,DATUM[Tahiti_79,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6690]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4690]]";
    }
}
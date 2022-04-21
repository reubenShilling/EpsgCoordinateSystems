namespace EpsgCoordinateSystems.Other
{
    public class Maupiti_83 : IEpsgCoordinateSystem
    {
        public string Name => "Maupiti 83";
        public long Srid => 4692;

        public string OgcWkt =>
            "GEOGCS[Maupiti 83,DATUM[Maupiti_83,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[217.037,86.959,23.956,0,0,0,0],AUTHORITY[EPSG,6692]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4692]]";

        public string EsriWkt =>
            "GEOGCS[Maupiti 83,DATUM[Maupiti_83,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[217.037,86.959,23.956,0,0,0,0],AUTHORITY[EPSG,6692]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4692]]";
    }
}
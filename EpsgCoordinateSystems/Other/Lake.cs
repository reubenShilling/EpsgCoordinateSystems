namespace EpsgCoordinateSystems.Other
{
    public class Lake : IEpsgCoordinateSystem
    {
        public string Name => "Lake";
        public string Units => "Unspecified";
public long Srid => 4249;

        public string OgcWkt =>
            "GEOGCS[Lake,DATUM[Lake,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6249]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4249]]";

        public string EsriWkt =>
            "GEOGCS[Lake,DATUM[Lake,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6249]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4249]]";
    }
}
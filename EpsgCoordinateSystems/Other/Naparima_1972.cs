namespace EpsgCoordinateSystems.Other
{
    public class Naparima_1972 : IEpsgCoordinateSystem
    {
        public string Name => "Naparima 1972";
        public string Units => "Unspecified";
public long Srid => 4271;

        public string OgcWkt =>
            "GEOGCS[Naparima 1972,DATUM[Naparima_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6271]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4271]]";

        public string EsriWkt =>
            "GEOGCS[Naparima 1972,DATUM[Naparima_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6271]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4271]]";
    }
}
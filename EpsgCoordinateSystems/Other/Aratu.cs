namespace EpsgCoordinateSystems.Other
{
    public class Aratu : IEpsgCoordinateSystem
    {
        public string Name => "Aratu";
        public string Units => "Unspecified";
public long Srid => 4208;

        public string OgcWkt =>
            "GEOGCS[Aratu,DATUM[Aratu,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6208]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4208]]";

        public string EsriWkt =>
            "GEOGCS[Aratu,DATUM[Aratu,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6208]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4208]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class fk89 : IEpsgCoordinateSystem
    {
        public string Name => "fk89";
        public string Units => "Unspecified";
public long Srid => 4753;

        public string OgcWkt =>
            "GEOGCS[fk89,DATUM[fk89,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6753]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4753]]";

        public string EsriWkt =>
            "GEOGCS[fk89,DATUM[fk89,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6753]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4753]]";
    }
}
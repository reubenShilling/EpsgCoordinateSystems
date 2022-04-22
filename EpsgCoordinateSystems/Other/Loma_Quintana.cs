namespace EpsgCoordinateSystems.Other
{
    public class Loma_Quintana : IEpsgCoordinateSystem
    {
        public string Name => "Loma Quintana";
        public string Units => "Unspecified";
public long Srid => 4288;

        public string OgcWkt =>
            "GEOGCS[Loma Quintana,DATUM[Loma_Quintana,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6288]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4288]]";

        public string EsriWkt =>
            "GEOGCS[Loma Quintana,DATUM[Loma_Quintana,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6288]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4288]]";
    }
}
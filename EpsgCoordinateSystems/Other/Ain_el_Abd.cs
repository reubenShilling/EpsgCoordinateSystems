namespace EpsgCoordinateSystems.Other
{
    public class Ain_el_Abd : IEpsgCoordinateSystem
    {
        public string Name => "Ain el Abd";
        public string Units => "Unspecified";
public long Srid => 4204;

        public string OgcWkt =>
            "GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]]";

        public string EsriWkt =>
            "GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]]";
    }
}
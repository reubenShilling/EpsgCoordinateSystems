namespace EpsgCoordinateSystems.Other
{
    public class Pitcairn_1967 : IEpsgCoordinateSystem
    {
        public string Name => "Pitcairn 1967";
        public string Units => "Unspecified";
public long Srid => 4729;

        public string OgcWkt =>
            "GEOGCS[Pitcairn 1967,DATUM[Pitcairn_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[185,165,42,0,0,0,0],AUTHORITY[EPSG,6729]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4729]]";

        public string EsriWkt =>
            "GEOGCS[Pitcairn 1967,DATUM[Pitcairn_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[185,165,42,0,0,0,0],AUTHORITY[EPSG,6729]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4729]]";
    }
}
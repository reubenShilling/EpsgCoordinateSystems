namespace EpsgCoordinateSystems.Other
{
    public class IGN_1962_Kerguelen : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1962 Kerguelen";
        public long Srid => 4698;

        public string OgcWkt =>
            "GEOGCS[IGN 1962 Kerguelen,DATUM[IGN_1962_Kerguelen,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,-187,103,0,0,0,0],AUTHORITY[EPSG,6698]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4698]]";

        public string EsriWkt =>
            "GEOGCS[IGN 1962 Kerguelen,DATUM[IGN_1962_Kerguelen,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,-187,103,0,0,0,0],AUTHORITY[EPSG,6698]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4698]]";
    }
}
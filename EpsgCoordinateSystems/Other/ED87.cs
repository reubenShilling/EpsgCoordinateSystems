namespace EpsgCoordinateSystems.Other
{
    public class ED87 : IEpsgCoordinateSystem
    {
        public string Name => "ED87";
        public string Units => "Unspecified";
public long Srid => 4231;

        public string OgcWkt =>
            "GEOGCS[ED87,DATUM[European_Datum_1987,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6231]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4231]]";

        public string EsriWkt =>
            "GEOGCS[ED87,DATUM[European_Datum_1987,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6231]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4231]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class ELD79 : IEpsgCoordinateSystem
    {
        public string Name => "ELD79";
        public string Units => "Unspecified";
public long Srid => 4159;

        public string OgcWkt =>
            "GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]]";

        public string EsriWkt =>
            "GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]]";
    }
}
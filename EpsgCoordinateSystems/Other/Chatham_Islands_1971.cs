namespace EpsgCoordinateSystems.Other
{
    public class Chatham_Islands_1971 : IEpsgCoordinateSystem
    {
        public string Name => "Chatham Islands 1971";
        public string Units => "Unspecified";
public long Srid => 4672;

        public string OgcWkt =>
            "GEOGCS[Chatham Islands 1971,DATUM[Chatham_Islands_Datum_1971,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[175,-38,113,0,0,0,0],AUTHORITY[EPSG,6672]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4672]]";

        public string EsriWkt => "GEOGCS[Chatham Islands 1971,DATUM[D_Chatham_Island_1971,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
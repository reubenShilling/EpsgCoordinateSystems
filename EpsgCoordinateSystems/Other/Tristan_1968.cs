namespace EpsgCoordinateSystems.Other
{
    public class Tristan_1968 : IEpsgCoordinateSystem
    {
        public string Name => "Tristan 1968";
        public long Srid => 4734;

        public string OgcWkt =>
            "GEOGCS[Tristan 1968,DATUM[Tristan_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-632,438,-609,0,0,0,0],AUTHORITY[EPSG,6734]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4734]]";

        public string EsriWkt =>
            "GEOGCS[Tristan 1968,DATUM[Tristan_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-632,438,-609,0,0,0,0],AUTHORITY[EPSG,6734]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4734]]";
    }
}
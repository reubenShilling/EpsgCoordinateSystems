namespace EpsgCoordinateSystems.Other
{
    public class Naparima_1955 : IEpsgCoordinateSystem
    {
        public string Name => "Naparima 1955";
        public long Srid => 4158;

        public string OgcWkt =>
            "GEOGCS[Naparima 1955,DATUM[Naparima_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6158]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4158]]";

        public string EsriWkt =>
            "GEOGCS[Naparima 1955,DATUM[Naparima_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6158]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4158]]";
    }
}
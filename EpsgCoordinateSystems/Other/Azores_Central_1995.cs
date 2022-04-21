namespace EpsgCoordinateSystems.Other
{
    public class Azores_Central_1995 : IEpsgCoordinateSystem
    {
        public string Name => "Azores Central 1995";
        public long Srid => 4665;

        public string OgcWkt =>
            "GEOGCS[Azores Central 1995,DATUM[Azores_Central_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6665]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4665]]";

        public string EsriWkt =>
            "GEOGCS[Azores Central 1995,DATUM[Azores_Central_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6665]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4665]]";
    }
}
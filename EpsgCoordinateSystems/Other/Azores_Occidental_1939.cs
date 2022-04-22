namespace EpsgCoordinateSystems.Other
{
    public class Azores_Occidental_1939 : IEpsgCoordinateSystem
    {
        public string Name => "Azores Occidental 1939";
        public string Units => "Unspecified";
public long Srid => 4182;

        public string OgcWkt =>
            "GEOGCS[Azores Occidental 1939,DATUM[Azores_Occidental_Islands_1939,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6182]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4182]]";

        public string EsriWkt => "GEOGCS[Azores Occidental 1939,DATUM[D_Azores_Occidental_Islands_1939,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Selvagem_Grande : IEpsgCoordinateSystem
    {
        public string Name => "Selvagem Grande";
        public string Units => "Unspecified";
public long Srid => 4616;

        public string OgcWkt =>
            "GEOGCS[Selvagem Grande,DATUM[Selvagem_Grande,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6616]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4616]]";

        public string EsriWkt => "GEOGCS[Selvagem Grande,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
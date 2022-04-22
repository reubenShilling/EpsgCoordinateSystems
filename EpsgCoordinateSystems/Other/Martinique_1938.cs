namespace EpsgCoordinateSystems.Other
{
    public class Martinique_1938 : IEpsgCoordinateSystem
    {
        public string Name => "Martinique 1938";
        public string Units => "Unspecified";
public long Srid => 4625;

        public string OgcWkt =>
            "GEOGCS[Martinique 1938,DATUM[Martinique_1938,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6625]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4625]]";

        public string EsriWkt => "GEOGCS[Martinique 1938,DATUM[D_Fort_Desaix,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
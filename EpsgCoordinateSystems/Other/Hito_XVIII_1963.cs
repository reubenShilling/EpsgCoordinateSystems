namespace EpsgCoordinateSystems.Other
{
    public class Hito_XVIII_1963 : IEpsgCoordinateSystem
    {
        public string Name => "Hito XVIII 1963";
        public string Units => "Unspecified";
public long Srid => 4254;

        public string OgcWkt =>
            "GEOGCS[Hito XVIII 1963,DATUM[Hito_XVIII_1963,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6254]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4254]]";

        public string EsriWkt => "GEOGCS[Hito XVIII 1963,DATUM[D_Hito_XVIII_1963,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
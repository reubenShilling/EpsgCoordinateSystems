namespace EpsgCoordinateSystems.Other
{
    public class IGN72_Nuku_Hiva : IEpsgCoordinateSystem
    {
        public string Name => "IGN72 Nuku Hiva";
        public string Units => "Unspecified";
public long Srid => 4630;

        public string OgcWkt =>
            "GEOGCS[IGN72 Nuku Hiva,DATUM[IGN72_Nuku_Hiva,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6630]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4630]]";

        public string EsriWkt => "GEOGCS[IGN72 Nuku Hiva,DATUM[D_IGN72_Nuku_Hiva,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
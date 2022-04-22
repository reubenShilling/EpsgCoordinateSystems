namespace EpsgCoordinateSystems.Categories.Other
{
    public class ED50 : IEpsgCoordinateSystem
    {
        public string Name => "ED50";
        public string Units => "Unspecified";
public int Srid => 4230;

        public string OgcWkt =>
            "GEOGCS[ED50,DATUM[European_Datum_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6230]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4230]]";

        public string EsriWkt => "GEOGCS[ED50,DATUM[D_European_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
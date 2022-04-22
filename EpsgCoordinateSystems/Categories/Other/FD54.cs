namespace EpsgCoordinateSystems.Categories.Other
{
    public class FD54 : IEpsgCoordinateSystem
    {
        public string Name => "FD54";
        public string Units => "Unspecified";
public int Srid => 4741;

        public string OgcWkt =>
            "GEOGCS[FD54,DATUM[Faroe_Datum_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6741]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4741]]";

        public string EsriWkt => "GEOGCS[FD54,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
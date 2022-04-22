namespace EpsgCoordinateSystems.Categories.Other
{
    public class Reunion_1947 : IEpsgCoordinateSystem
    {
        public string Name => "Reunion 1947";
        public string Units => "Unspecified";
public int Srid => 4626;

        public string OgcWkt =>
            "GEOGCS[Reunion 1947,DATUM[Reunion_1947,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6626]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4626]]";

        public string EsriWkt => "GEOGCS[Reunion 1947,DATUM[D_Reunion_1947,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
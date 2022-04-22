namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bissau : IEpsgCoordinateSystem
    {
        public string Name => "Bissau";
        public string Units => "Unspecified";
public int Srid => 4165;

        public string OgcWkt =>
            "GEOGCS[Bissau,DATUM[Bissau,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-173,253,27,0,0,0,0],AUTHORITY[EPSG,6165]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4165]]";

        public string EsriWkt => "GEOGCS[Bissau,DATUM[D_Bissau,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
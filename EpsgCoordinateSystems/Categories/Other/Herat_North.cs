namespace EpsgCoordinateSystems.Categories.Other
{
    public class Herat_North : IEpsgCoordinateSystem
    {
        public string Name => "Herat North";
        public string Units => "Unspecified";
public int Srid => 4255;

        public string OgcWkt =>
            "GEOGCS[Herat North,DATUM[Herat_North,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-333,-222,114,0,0,0,0],AUTHORITY[EPSG,6255]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4255]]";

        public string EsriWkt => "GEOGCS[Herat North,DATUM[D_Herat_North,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
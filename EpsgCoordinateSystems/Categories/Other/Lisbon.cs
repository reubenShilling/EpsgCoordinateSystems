namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lisbon : IEpsgCoordinateSystem
    {
        public string Name => "Lisbon";
        public string Units => "Unspecified";
public int Srid => 4207;

        public string OgcWkt =>
            "GEOGCS[Lisbon,DATUM[Lisbon_1937,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6207]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4207]]";

        public string EsriWkt => "GEOGCS[Lisbon,DATUM[D_Lisbon,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
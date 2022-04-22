namespace EpsgCoordinateSystems.Categories.Other
{
    public class Douala_1948 : IEpsgCoordinateSystem
    {
        public string Name => "Douala 1948";
        public string Units => "Unspecified";
public int Srid => 4192;

        public string OgcWkt =>
            "GEOGCS[Douala 1948,DATUM[Douala_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206.1,-174.7,-87.7,0,0,0,0],AUTHORITY[EPSG,6192]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4192]]";

        public string EsriWkt => "GEOGCS[Douala 1948,DATUM[D_Douala_1948,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Categories.Other
{
    public class Luxembourg_1930 : IEpsgCoordinateSystem
    {
        public string Name => "Luxembourg 1930";
        public string Units => "Unspecified";
public int Srid => 4181;

        public string OgcWkt =>
            "GEOGCS[Luxembourg 1930,DATUM[Luxembourg_1930,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-193,13.7,-39.3,-0.41,-2.933,2.688,0.43],AUTHORITY[EPSG,6181]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4181]]";

        public string EsriWkt => "GEOGCS[Luxembourg 1930,DATUM[D_Luxembourg_1930,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
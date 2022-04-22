namespace EpsgCoordinateSystems.Other
{
    public class Chos_Malal_1914 : IEpsgCoordinateSystem
    {
        public string Name => "Chos Malal 1914";
        public string Units => "Unspecified";
public long Srid => 4160;

        public string OgcWkt =>
            "GEOGCS[Chos Malal 1914,DATUM[Chos_Malal_1914,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6160]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4160]]";

        public string EsriWkt =>
            "GEOGCS[Chos Malal 1914,DATUM[Chos_Malal_1914,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6160]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4160]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Perroud_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Perroud 1950";
        public string Units => "Unspecified";
public long Srid => 4637;

        public string OgcWkt =>
            "GEOGCS[Perroud 1950,DATUM[Pointe_Geologie_Perroud_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[325,154,172,0,0,0,0],AUTHORITY[EPSG,6637]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4637]]";

        public string EsriWkt =>
            "GEOGCS[Perroud 1950,DATUM[Pointe_Geologie_Perroud_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[325,154,172,0,0,0,0],AUTHORITY[EPSG,6637]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4637]]";
    }
}
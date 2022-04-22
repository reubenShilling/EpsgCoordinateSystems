namespace EpsgCoordinateSystems.Other
{
    public class Diego_Garcia_1969 : IEpsgCoordinateSystem
    {
        public string Name => "Diego Garcia 1969";
        public string Units => "Unspecified";
public long Srid => 4724;

        public string OgcWkt =>
            "GEOGCS[Diego Garcia 1969,DATUM[Diego_Garcia_1969,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[208,-435,-229,0,0,0,0],AUTHORITY[EPSG,6724]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4724]]";

        public string EsriWkt =>
            "GEOGCS[Diego Garcia 1969,DATUM[Diego_Garcia_1969,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[208,-435,-229,0,0,0,0],AUTHORITY[EPSG,6724]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4724]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Sapper_Hill_1943 : IEpsgCoordinateSystem
    {
        public string Name => "Sapper Hill 1943";
        public string Units => "Unspecified";
public long Srid => 4292;

        public string OgcWkt =>
            "GEOGCS[Sapper Hill 1943,DATUM[Sapper_Hill_1943,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-355,21,72,0,0,0,0],AUTHORITY[EPSG,6292]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4292]]";

        public string EsriWkt =>
            "GEOGCS[Sapper Hill 1943,DATUM[Sapper_Hill_1943,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-355,21,72,0,0,0,0],AUTHORITY[EPSG,6292]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4292]]";
    }
}
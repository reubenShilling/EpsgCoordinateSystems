namespace EpsgCoordinateSystems.Other
{
    public class South_Georgia_1968 : IEpsgCoordinateSystem
    {
        public string Name => "South Georgia 1968";
        public string Units => "Unspecified";
public long Srid => 4722;

        public string OgcWkt =>
            "GEOGCS[South Georgia 1968,DATUM[South_Georgia_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-794,119,-298,0,0,0,0],AUTHORITY[EPSG,6722]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4722]]";

        public string EsriWkt =>
            "GEOGCS[South Georgia 1968,DATUM[South_Georgia_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-794,119,-298,0,0,0,0],AUTHORITY[EPSG,6722]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4722]]";
    }
}
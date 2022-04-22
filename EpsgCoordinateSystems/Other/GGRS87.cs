namespace EpsgCoordinateSystems.Other
{
    public class GGRS87 : IEpsgCoordinateSystem
    {
        public string Name => "GGRS87";
        public string Units => "Unspecified";
public long Srid => 4121;

        public string OgcWkt =>
            "GEOGCS[GGRS87,DATUM[Greek_Geodetic_Reference_System_1987,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-199.87,74.79,246.62,0,0,0,0],AUTHORITY[EPSG,6121]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4121]]";

        public string EsriWkt =>
            "GEOGCS[GGRS87,DATUM[Greek_Geodetic_Reference_System_1987,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-199.87,74.79,246.62,0,0,0,0],AUTHORITY[EPSG,6121]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4121]]";
    }
}
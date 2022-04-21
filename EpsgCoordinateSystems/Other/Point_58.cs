namespace EpsgCoordinateSystems.Other
{
    public class Point_58 : IEpsgCoordinateSystem
    {
        public string Name => "Point 58";
        public long Srid => 4620;

        public string OgcWkt =>
            "GEOGCS[Point 58,DATUM[Point_58,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-106,-129,165,0,0,0,0],AUTHORITY[EPSG,6620]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4620]]";

        public string EsriWkt =>
            "GEOGCS[Point 58,DATUM[Point_58,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-106,-129,165,0,0,0,0],AUTHORITY[EPSG,6620]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4620]]";
    }
}
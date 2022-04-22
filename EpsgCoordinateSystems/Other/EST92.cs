namespace EpsgCoordinateSystems.Other
{
    public class EST92 : IEpsgCoordinateSystem
    {
        public string Name => "EST92";
        public string Units => "Unspecified";
public long Srid => 4133;

        public string OgcWkt =>
            "GEOGCS[EST92,DATUM[Estonia_1992,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.055,-0.541,-0.185,0.0183,-0.0003,-0.007,-0.014],AUTHORITY[EPSG,6133]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4133]]";

        public string EsriWkt =>
            "GEOGCS[EST92,DATUM[Estonia_1992,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.055,-0.541,-0.185,0.0183,-0.0003,-0.007,-0.014],AUTHORITY[EPSG,6133]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4133]]";
    }
}
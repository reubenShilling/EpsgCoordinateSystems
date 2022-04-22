namespace EpsgCoordinateSystems.Other
{
    public class Merchich : IEpsgCoordinateSystem
    {
        public string Name => "Merchich";
        public string Units => "Unspecified";
public long Srid => 4261;

        public string OgcWkt =>
            "GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]]";

        public string EsriWkt =>
            "GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]]";
    }
}
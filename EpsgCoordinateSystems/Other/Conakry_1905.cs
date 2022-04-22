namespace EpsgCoordinateSystems.Other
{
    public class Conakry_1905 : IEpsgCoordinateSystem
    {
        public string Name => "Conakry 1905";
        public string Units => "Unspecified";
public long Srid => 4315;

        public string OgcWkt =>
            "GEOGCS[Conakry 1905,DATUM[Conakry_1905,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-23,259,-9,0,0,0,0],AUTHORITY[EPSG,6315]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4315]]";

        public string EsriWkt =>
            "GEOGCS[Conakry 1905,DATUM[Conakry_1905,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-23,259,-9,0,0,0,0],AUTHORITY[EPSG,6315]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4315]]";
    }
}
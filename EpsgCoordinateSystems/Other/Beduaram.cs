namespace EpsgCoordinateSystems.Other
{
    public class Beduaram : IEpsgCoordinateSystem
    {
        public string Name => "Beduaram";
        public long Srid => 4213;

        public string OgcWkt =>
            "GEOGCS[Beduaram,DATUM[Beduaram,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-106,-87,188,0,0,0,0],AUTHORITY[EPSG,6213]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4213]]";

        public string EsriWkt =>
            "GEOGCS[Beduaram,DATUM[Beduaram,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-106,-87,188,0,0,0,0],AUTHORITY[EPSG,6213]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4213]]";
    }
}
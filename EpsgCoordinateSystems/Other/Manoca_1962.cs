namespace EpsgCoordinateSystems.Other
{
    public class Manoca_1962 : IEpsgCoordinateSystem
    {
        public string Name => "Manoca 1962";
        public string Units => "Unspecified";
public long Srid => 4193;

        public string OgcWkt =>
            "GEOGCS[Manoca 1962,DATUM[Manoca_1962,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6193]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4193]]";

        public string EsriWkt =>
            "GEOGCS[Manoca 1962,DATUM[Manoca_1962,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6193]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4193]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Michigan : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 Michigan";
        public string Units => "Unspecified";
public long Srid => 4268;

        public string OgcWkt =>
            "GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]]";

        public string EsriWkt =>
            "GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]]";
    }
}
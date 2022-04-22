namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD27_Michigan : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 Michigan";
        public string Units => "Unspecified";
public int Srid => 4268;

        public string OgcWkt =>
            "GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]]";

        public string EsriWkt => "GEOGCS[NAD27 Michigan,DATUM[D_North_American_Michigan,SPHEROID[Clarke_1866_Michigan,6378450.047548896,294.9786971646747]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
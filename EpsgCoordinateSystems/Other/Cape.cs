namespace EpsgCoordinateSystems.Other
{
    public class Cape : IEpsgCoordinateSystem
    {
        public string Name => "Cape";
        public string Units => "Unspecified";
public long Srid => 4222;

        public string OgcWkt =>
            "GEOGCS[Cape,DATUM[Cape,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],AUTHORITY[EPSG,6222]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4222]]";

        public string EsriWkt => "GEOGCS[Cape,DATUM[D_Cape,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
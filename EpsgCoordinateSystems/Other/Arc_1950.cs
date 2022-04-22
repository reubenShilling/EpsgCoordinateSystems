namespace EpsgCoordinateSystems.Other
{
    public class Arc_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Arc 1950";
        public string Units => "Unspecified";
public long Srid => 4209;

        public string OgcWkt =>
            "GEOGCS[Arc 1950,DATUM[Arc_1950,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],AUTHORITY[EPSG,6209]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4209]]";

        public string EsriWkt => "GEOGCS[Arc 1950,DATUM[D_Arc_1950,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
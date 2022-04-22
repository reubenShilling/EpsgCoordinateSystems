namespace EpsgCoordinateSystems.Other
{
    public class Douala : IEpsgCoordinateSystem
    {
        public string Name => "Douala";
        public string Units => "Unspecified";
public long Srid => 4228;

        public string OgcWkt =>
            "GEOGCS[Douala,DATUM[Douala,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6228]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4228]]";

        public string EsriWkt => "GEOGCS[Douala,DATUM[D_Douala,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
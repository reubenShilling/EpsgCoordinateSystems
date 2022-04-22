namespace EpsgCoordinateSystems.Categories.Other
{
    public class Garoua : IEpsgCoordinateSystem
    {
        public string Name => "Garoua";
        public string Units => "Unspecified";
public int Srid => 4234;

        public string OgcWkt =>
            "GEOGCS[Garoua,DATUM[Garoua,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6234]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4234]]";

        public string EsriWkt => "GEOGCS[Garoua,DATUM[D_,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
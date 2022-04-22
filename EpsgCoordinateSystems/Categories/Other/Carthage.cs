namespace EpsgCoordinateSystems.Categories.Other
{
    public class Carthage : IEpsgCoordinateSystem
    {
        public string Name => "Carthage";
        public string Units => "Unspecified";
public int Srid => 4223;

        public string OgcWkt =>
            "GEOGCS[Carthage,DATUM[Carthage,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6223]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4223]]";

        public string EsriWkt => "GEOGCS[Carthage,DATUM[D_Carthage,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
namespace EpsgCoordinateSystems.Other
{
    public class Yoff : IEpsgCoordinateSystem
    {
        public string Name => "Yoff";
        public string Units => "Unspecified";
public long Srid => 4310;

        public string OgcWkt =>
            "GEOGCS[Yoff,DATUM[Yoff,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6310]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4310]]";

        public string EsriWkt => "GEOGCS[Yoff,DATUM[D_Yoff,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
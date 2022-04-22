using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Voirol_1879 : IEpsgCoordinateSystem
    {private const int _srid = 4671; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Voirol 1879";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Voirol 1879,DATUM[Voirol_1879,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6671]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4671]]";

        public string EsriWkt => "GEOGCS[Voirol 1879,DATUM[D_Voirol_1879,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
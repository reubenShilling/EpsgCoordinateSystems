using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Merchich : IEpsgCoordinateSystem
    {private const int _srid = 4261; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Merchich";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]]";

        public string EsriWkt => "GEOGCS[Merchich,DATUM[D_Merchich,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
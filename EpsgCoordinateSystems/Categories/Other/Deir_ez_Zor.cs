using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Deir_ez_Zor : IEpsgCoordinateSystem
    {private const int _srid = 4227; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Deir ez Zor";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Deir ez Zor,DATUM[Deir_ez_Zor,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6227]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4227]]";

        public string EsriWkt => "GEOGCS[Deir ez Zor,DATUM[D_Deir_ez_Zor,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
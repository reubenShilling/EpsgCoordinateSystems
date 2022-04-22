using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class M_poraloko : IEpsgCoordinateSystem
    {private const int _srid = 4266; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "M'poraloko";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[M'poraloko,DATUM[M_poraloko,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6266]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4266]]";

        public string EsriWkt => "GEOGCS[M'poraloko,DATUM[D_Mporaloko,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
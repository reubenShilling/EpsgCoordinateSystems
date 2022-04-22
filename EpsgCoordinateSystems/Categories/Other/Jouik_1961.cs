using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Jouik_1961 : IEpsgCoordinateSystem
    {private const int _srid = 4679; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Jouik 1961";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Jouik 1961,DATUM[Jouik_1961,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-80.01,253.26,291.19,0,0,0,0],AUTHORITY[EPSG,6679]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4679]]";

        public string EsriWkt => "GEOGCS[Jouik 1961,DATUM[D_Jouik_1961,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
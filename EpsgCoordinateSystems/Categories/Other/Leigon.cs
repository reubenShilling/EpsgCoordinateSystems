using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Leigon : IEpsgCoordinateSystem
    {private const int _srid = 4250; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Leigon";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Leigon,DATUM[Leigon,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-130,29,364,0,0,0,0],AUTHORITY[EPSG,6250]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4250]]";

        public string EsriWkt => "GEOGCS[Leigon,DATUM[D_Leigon,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
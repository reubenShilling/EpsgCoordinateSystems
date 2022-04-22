using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kasai_1953 : IEpsgCoordinateSystem
    {private const int _srid = 4696; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kasai 1953";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Kasai 1953,DATUM[Kasai_1953,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6696]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4696]]";

        public string EsriWkt => "GEOGCS[Kasai 1953,DATUM[D_Kasai_1955,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
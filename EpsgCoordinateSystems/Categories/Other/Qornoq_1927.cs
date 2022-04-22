using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Qornoq_1927 : IEpsgCoordinateSystem
    {private const int _srid = 4194; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Qornoq 1927";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194]]";

        public string EsriWkt => "GEOGCS[Qornoq 1927,DATUM[D_Qornoq_1927,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
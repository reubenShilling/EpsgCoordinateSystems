using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Zanderij : IEpsgCoordinateSystem
    {private const int _srid = 4311; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Zanderij";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Zanderij,DATUM[Zanderij,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-265,120,-358,0,0,0,0],AUTHORITY[EPSG,6311]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4311]]";

        public string EsriWkt => "GEOGCS[Zanderij,DATUM[D_Zanderij,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
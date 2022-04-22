using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class K0_1949 : IEpsgCoordinateSystem
    {private const int _srid = 4631; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "K0 1949";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[K0 1949,DATUM[K0_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,-187,103,0,0,0,0],AUTHORITY[EPSG,6631]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4631]]";

        public string EsriWkt => "GEOGCS[K0 1949,DATUM[D_K0_1949,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yacare : IEpsgCoordinateSystem
    {private const int _srid = 4309; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Yacare";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Yacare,DATUM[Yacare,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-155,171,37,0,0,0,0],AUTHORITY[EPSG,6309]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4309]]";

        public string EsriWkt => "GEOGCS[Yacare,DATUM[D_Yacare,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Azores_Oriental_1940 : IEpsgCoordinateSystem
    {private const int _srid = 4184; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Azores Oriental 1940";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Azores Oriental 1940,DATUM[Azores_Oriental_Islands_1940,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-203,141,53,0,0,0,0],AUTHORITY[EPSG,6184]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4184]]";

        public string EsriWkt => "GEOGCS[Azores Oriental 1940,DATUM[D_Azores_Oriental_Islands_1940,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Azores_Oriental_1995 : IEpsgCoordinateSystem
    {private const int _srid = 4664; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Azores Oriental 1995";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Azores Oriental 1995,DATUM[Azores_Oriental_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6664]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4664]]";

        public string EsriWkt => "GEOGCS[Azores Oriental 1995,DATUM[D_Azores_Oriental_Islands_1995,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
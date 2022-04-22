using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Sapper_Hill_1943 : IEpsgCoordinateSystem
    {private const int _srid = 4292; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Sapper Hill 1943";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Sapper Hill 1943,DATUM[Sapper_Hill_1943,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-355,21,72,0,0,0,0],AUTHORITY[EPSG,6292]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4292]]";

        public string EsriWkt => "GEOGCS[Sapper Hill 1943,DATUM[D_Sapper_Hill_1943,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
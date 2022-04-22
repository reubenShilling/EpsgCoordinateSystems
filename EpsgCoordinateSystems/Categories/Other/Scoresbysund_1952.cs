using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Scoresbysund_1952 : IEpsgCoordinateSystem
    {private const int _srid = 4195; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Scoresbysund 1952";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Scoresbysund 1952,DATUM[Scoresbysund_1952,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[105,326,-102.5,0,0,0.814,-0.6],AUTHORITY[EPSG,6195]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4195]]";

        public string EsriWkt => "GEOGCS[Scoresbysund 1952,DATUM[D_Scoresbysund_1952,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
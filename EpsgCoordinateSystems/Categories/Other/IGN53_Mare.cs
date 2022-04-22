using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN53_Mare : IEpsgCoordinateSystem
    {private const int _srid = 4641; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN53 Mare";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGN53 Mare,DATUM[IGN53_Mare,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6641]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4641]]";

        public string EsriWkt => "GEOGCS[IGN53 Mare,DATUM[D_IGN53_Mare,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
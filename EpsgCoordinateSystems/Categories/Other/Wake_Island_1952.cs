using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Wake_Island_1952 : IEpsgCoordinateSystem
    {private const int _srid = 4733; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wake Island 1952";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Wake Island 1952,DATUM[Wake_Island_1952,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[276,-57,149,0,0,0,0],AUTHORITY[EPSG,6733]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4733]]";

        public string EsriWkt => "GEOGCS[Wake Island 1952,DATUM[D_Wake_Island_1952,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
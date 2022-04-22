using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Phoenix_Islands_1966 : IEpsgCoordinateSystem
    {private const int _srid = 4716; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Phoenix Islands 1966";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Phoenix Islands 1966,DATUM[Phoenix_Islands_1966,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[298,-304,-375,0,0,0,0],AUTHORITY[EPSG,6716]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4716]]";

        public string EsriWkt => "GEOGCS[Phoenix Islands 1966,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
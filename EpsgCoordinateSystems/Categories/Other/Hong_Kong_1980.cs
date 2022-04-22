using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hong_Kong_1980 : IEpsgCoordinateSystem
    {private const int _srid = 4611; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hong Kong 1980";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Hong Kong 1980,DATUM[Hong_Kong_1980,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-162.619,-276.959,-161.764,0.067753,-2.24365,-1.15883,-1.09425],AUTHORITY[EPSG,6611]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4611]]";

        public string EsriWkt => "GEOGCS[Hong Kong 1980,DATUM[D_Hong_Kong_1980,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
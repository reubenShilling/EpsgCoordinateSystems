using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN56_Lifou : IEpsgCoordinateSystem
    {private const int _srid = 4633; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN56 Lifou";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGN56 Lifou,DATUM[IGN56_Lifou,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6633]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4633]]";

        public string EsriWkt => "GEOGCS[IGN56 Lifou,DATUM[D_IGN56_Lifou,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
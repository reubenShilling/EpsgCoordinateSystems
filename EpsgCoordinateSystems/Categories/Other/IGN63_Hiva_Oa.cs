using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN63_Hiva_Oa : IEpsgCoordinateSystem
    {private const int _srid = 4689; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN63 Hiva Oa";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGN63 Hiva Oa,DATUM[IGN63_Hiva_Oa,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6689]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4689]]";

        public string EsriWkt => "GEOGCS[IGN63 Hiva Oa,DATUM[D_IGN63_Hiva_Oa,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
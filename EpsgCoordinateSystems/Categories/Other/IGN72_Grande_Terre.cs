using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN72_Grande_Terre : IEpsgCoordinateSystem
    {private const int _srid = 4662; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN72 Grande Terre";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGN72 Grande Terre,DATUM[IGN72_Grande_Terre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6634]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4662]]";

        public string EsriWkt => "GEOGCS[IGN72 Grande Terre,DATUM[D_IGN72_Grande_Terre,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}
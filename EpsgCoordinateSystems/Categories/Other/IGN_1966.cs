using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1966 : IEpsgCoordinateSystem
    {private const int _srid = 5601; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1966";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN 1966,VERT_DATUM[IGN 1966,2005,AUTHORITY[EPSG,5196]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5601]]";

        public string EsriWkt => "VERT_CS[IGN 1966,VERT_DATUM[IGN 1966,2005],UNIT[m,1.0]]";
    }
}
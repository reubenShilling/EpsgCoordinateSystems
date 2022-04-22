using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1988_MG_height : IEpsgCoordinateSystem
    {private const int _srid = 5617; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1988 MG height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 MG height,VERT_DATUM[IGN 1988 MG,2005,AUTHORITY[EPSG,5211]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5617]]";

        public string EsriWkt => "VERT_CS[IGN 1988 MG height,VERT_DATUM[IGN 1988 MG,2005],UNIT[m,1.0]]";
    }
}
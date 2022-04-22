using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1988_SB_height : IEpsgCoordinateSystem
    {private const int _srid = 5619; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1988 SB height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 SB height,VERT_DATUM[IGN 1988 SB,2005,AUTHORITY[EPSG,5213]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5619]]";

        public string EsriWkt => "VERT_CS[IGN 1988 SB height,VERT_DATUM[IGN 1988 SB,2005],UNIT[m,1.0]]";
    }
}
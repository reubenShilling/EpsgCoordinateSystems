using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1992_LD_height : IEpsgCoordinateSystem
    {private const int _srid = 5618; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1992 LD height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN 1992 LD height,VERT_DATUM[IGN 1992 LD,2005,AUTHORITY[EPSG,5212]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5618]]";

        public string EsriWkt => "VERT_CS[IGN 1992 LD height,VERT_DATUM[IGN 1992 LD,2005],UNIT[m,1.0]]";
    }
}
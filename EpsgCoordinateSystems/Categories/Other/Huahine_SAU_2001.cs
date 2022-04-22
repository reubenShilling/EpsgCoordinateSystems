using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Huahine_SAU_2001 : IEpsgCoordinateSystem
    {private const int _srid = 5605; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Huahine SAU 2001";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Huahine SAU 2001,VERT_DATUM[Huahine SAU 2001,2005,AUTHORITY[EPSG,5200]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5605]]";

        public string EsriWkt => "VERT_CS[Huahine SAU 2001,VERT_DATUM[Huahine SAU 2001,2005],UNIT[m,1.0]]";
    }
}
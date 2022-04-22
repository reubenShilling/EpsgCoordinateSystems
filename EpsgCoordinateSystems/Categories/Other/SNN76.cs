using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class SNN76 : IEpsgCoordinateSystem
    {private const int _srid = 5785; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "SNN76";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[SNN76,VERT_DATUM[SNN76,2005,AUTHORITY[EPSG,5183]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5785]]";

        public string EsriWkt => "VERT_CS[SNN76,VERT_DATUM[SNN76,2005],UNIT[m,1.0]]";
    }
}
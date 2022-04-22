using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Auckland : IEpsgCoordinateSystem
    {private const int _srid = 5759; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Auckland";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Auckland,VERT_DATUM[Auckland,2005,AUTHORITY[EPSG,5157]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5759]]";

        public string EsriWkt => "VERT_CS[Auckland,VERT_DATUM[Auckland,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Durres : IEpsgCoordinateSystem
    {private const int _srid = 5777; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Durres";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Durres,VERT_DATUM[Durres,2005,AUTHORITY[EPSG,5175]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5777]]";

        public string EsriWkt => "VERT_CS[Durres,VERT_DATUM[Durres,2005],UNIT[m,1.0]]";
    }
}
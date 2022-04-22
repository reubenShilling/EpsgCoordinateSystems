using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGPF : IEpsgCoordinateSystem
    {private const int _srid = 5600; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NGPF";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NGPF,VERT_DATUM[Nivellement General de Polynesie Francaise,2005,AUTHORITY[EPSG,5195]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5600]]";

        public string EsriWkt => "VERT_CS[NGPF,VERT_DATUM[Nivellement General de Polynesie Francaise,2005],UNIT[m,1.0]]";
    }
}
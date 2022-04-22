using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGNC : IEpsgCoordinateSystem
    {private const int _srid = 5753; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NGNC";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NGNC,VERT_DATUM[Nivellement General de Nouvelle Caledonie,2005,AUTHORITY[EPSG,5151]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5753]]";

        public string EsriWkt => "VERT_CS[NGNC,VERT_DATUM[Nivellement General de Nouvelle Caledonie,2005],UNIT[m,1.0]]";
    }
}
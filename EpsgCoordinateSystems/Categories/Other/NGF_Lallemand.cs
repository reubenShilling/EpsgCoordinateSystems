using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGF_Lallemand : IEpsgCoordinateSystem
    {private const int _srid = 5719; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NGF Lallemand";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005,AUTHORITY[EPSG,5118]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5719]]";

        public string EsriWkt => "VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005],UNIT[m,1.0]]";
    }
}
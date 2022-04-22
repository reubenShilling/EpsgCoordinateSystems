using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGF_IGN69 : IEpsgCoordinateSystem
    {private const int _srid = 5720; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NGF IGN69";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005,AUTHORITY[EPSG,5119]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5720]]";

        public string EsriWkt => "VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005],UNIT[m,1.0]]";
    }
}
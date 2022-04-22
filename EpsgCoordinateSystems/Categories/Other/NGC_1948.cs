using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGC_1948 : IEpsgCoordinateSystem
    {private const int _srid = 5791; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NGC 1948";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NGC 1948,VERT_DATUM[Nivellement General de la Corse 1948,2005,AUTHORITY[EPSG,5189]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5791]]";

        public string EsriWkt => "VERT_CS[NGC 1948,VERT_DATUM[Nivellement General de la Corse 1948,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Taranaki : IEpsgCoordinateSystem
    {private const int _srid = 5769; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Taranaki";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Taranaki,VERT_DATUM[Taranaki,2005,AUTHORITY[EPSG,5167]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5769]]";

        public string EsriWkt => "VERT_CS[Taranaki,VERT_DATUM[Taranaki,2005],UNIT[m,1.0]]";
    }
}
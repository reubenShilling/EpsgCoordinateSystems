using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Guadeloupe_1988 : IEpsgCoordinateSystem
    {private const int _srid = 5757; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Guadeloupe 1988";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Guadeloupe 1988,VERT_DATUM[Guadeloupe 1988,2005,AUTHORITY[EPSG,5155]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5757]]";

        public string EsriWkt => "VERT_CS[Guadeloupe 1988,VERT_DATUM[Guadeloupe 1988,2005],UNIT[m,1.0]]";
    }
}
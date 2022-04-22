using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Guadeloupe_1951 : IEpsgCoordinateSystem
    {private const int _srid = 5795; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Guadeloupe 1951";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Guadeloupe 1951,VERT_DATUM[Guadeloupe 1951,2005,AUTHORITY[EPSG,5193]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5795]]";

        public string EsriWkt => "VERT_CS[Guadeloupe 1951,VERT_DATUM[Guadeloupe 1951,2005],UNIT[m,1.0]]";
    }
}
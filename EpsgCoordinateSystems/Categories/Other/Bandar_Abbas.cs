using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bandar_Abbas : IEpsgCoordinateSystem
    {private const int _srid = 5752; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bandar Abbas";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Bandar Abbas,VERT_DATUM[Bandar Abbas,2005,AUTHORITY[EPSG,5150]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5752]]";

        public string EsriWkt => "VERT_CS[Bandar Abbas,VERT_DATUM[Bandar Abbas,2005],UNIT[m,1.0]]";
    }
}
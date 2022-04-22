using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Landesnivellement_1902 : IEpsgCoordinateSystem
    {private const int _srid = 5728; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Landesnivellement 1902";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Landesnivellement 1902,VERT_DATUM[Landesnivellement 1902,2005,AUTHORITY[EPSG,5127]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5728]]";

        public string EsriWkt => "VERT_CS[Landesnivellement 1902,VERT_DATUM[Landesnivellement 1902,2005],UNIT[m,1.0]]";
    }
}
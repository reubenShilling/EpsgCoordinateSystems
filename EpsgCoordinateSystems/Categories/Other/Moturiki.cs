using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moturiki : IEpsgCoordinateSystem
    {private const int _srid = 5764; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Moturiki";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Moturiki,VERT_DATUM[Moturiki,2005,AUTHORITY[EPSG,5162]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5764]]";

        public string EsriWkt => "VERT_CS[Moturiki,VERT_DATUM[Moturiki,2005],UNIT[m,1.0]]";
    }
}
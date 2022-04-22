using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lyttleton : IEpsgCoordinateSystem
    {private const int _srid = 5763; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Lyttleton";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Lyttleton,VERT_DATUM[Lyttleton,2005,AUTHORITY[EPSG,5161]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5763]]";

        public string EsriWkt => "VERT_CS[Lyttleton,VERT_DATUM[Lyttleton,2005],UNIT[m,1.0]]";
    }
}
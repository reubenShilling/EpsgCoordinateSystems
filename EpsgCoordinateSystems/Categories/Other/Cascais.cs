using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Cascais : IEpsgCoordinateSystem
    {private const int _srid = 5780; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Cascais";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Cascais,VERT_DATUM[Cascais,2005,AUTHORITY[EPSG,5178]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5780]]";

        public string EsriWkt => "VERT_CS[Cascais,VERT_DATUM[Cascais,2005],UNIT[m,1.0]]";
    }
}
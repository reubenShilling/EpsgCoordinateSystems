using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Alicante : IEpsgCoordinateSystem
    {private const int _srid = 5782; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Alicante";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Alicante,VERT_DATUM[Alicante,2005,AUTHORITY[EPSG,5180]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5782]]";

        public string EsriWkt => "VERT_CS[Alicante,VERT_DATUM[Alicante,2005],UNIT[m,1.0]]";
    }
}
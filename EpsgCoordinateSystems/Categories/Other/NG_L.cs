using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NG_L : IEpsgCoordinateSystem
    {private const int _srid = 5774; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NG-L";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NG-L,VERT_DATUM[Nivellement General du Luxembourg,2005,AUTHORITY[EPSG,5172]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5774]]";

        public string EsriWkt => "VERT_CS[NG-L,VERT_DATUM[Nivellement General du Luxembourg,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NVN99 : IEpsgCoordinateSystem
    {private const int _srid = 5779; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NVN99";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NVN99,VERT_DATUM[National Vertical Network 1999,2005,AUTHORITY[EPSG,5177]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5779]]";

        public string EsriWkt => "VERT_CS[NVN99,VERT_DATUM[National Vertical Network 1999,2005],UNIT[m,1.0]]";
    }
}
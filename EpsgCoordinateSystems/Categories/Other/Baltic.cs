using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Baltic : IEpsgCoordinateSystem
    {private const int _srid = 5705; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Baltic";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Baltic,VERT_DATUM[Baltic Sea,2005,AUTHORITY[EPSG,5105]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5705]]";

        public string EsriWkt => "VERT_CS[Baltic,VERT_DATUM[Baltic Sea,2005],UNIT[m,1.0]]";
    }
}
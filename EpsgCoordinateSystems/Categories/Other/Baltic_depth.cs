using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Baltic_depth : IEpsgCoordinateSystem
    {private const int _srid = 5612; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Baltic depth";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Baltic depth,VERT_DATUM[Baltic Sea,2005,AUTHORITY[EPSG,5105]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5612]]";

        public string EsriWkt => "VERT_CS[Baltic depth,VERT_DATUM[Baltic Sea,2005],UNIT[m,1.0]]";
    }
}
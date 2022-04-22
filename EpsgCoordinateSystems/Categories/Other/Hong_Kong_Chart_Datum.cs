using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hong_Kong_Chart_Datum : IEpsgCoordinateSystem
    {private const int _srid = 5739; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hong Kong Chart Datum";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Hong Kong Chart Datum,VERT_DATUM[Hong Kong Chart Datum,2005,AUTHORITY[EPSG,5136]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5739]]";

        public string EsriWkt => "VERT_CS[Hong Kong Chart Datum,VERT_DATUM[Hong Kong Chart Datum,2005],UNIT[m,1.0]]";
    }
}
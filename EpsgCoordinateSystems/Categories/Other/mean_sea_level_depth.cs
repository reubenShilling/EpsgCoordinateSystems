using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class mean_sea_level_depth : IEpsgCoordinateSystem
    {private const int _srid = 5715; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "mean sea level depth";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[mean sea level depth,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5715]]";

        public string EsriWkt => "VERT_CS[mean sea level depth,VERT_DATUM[Mean Sea Level,2005],UNIT[m,1.0]]";
    }
}
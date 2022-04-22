using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class mean_sea_level_height : IEpsgCoordinateSystem
    {private const int _srid = 5714; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "mean sea level height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[mean sea level height,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5714]]";

        public string EsriWkt => "VERT_CS[mean sea level height,VERT_DATUM[Mean Sea Level,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fair_Isle : IEpsgCoordinateSystem
    {private const int _srid = 5741; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fair Isle";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Fair Isle,VERT_DATUM[Fair Isle,2005,AUTHORITY[EPSG,5139]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5741]]";

        public string EsriWkt => "VERT_CS[Fair Isle,VERT_DATUM[Fair Isle,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1988_SM_height : IEpsgCoordinateSystem
    {private const int _srid = 5620; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1988 SM height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 SM height,VERT_DATUM[IGN 1988 SM,2005,AUTHORITY[EPSG,5214]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5620]]";

        public string EsriWkt => "VERT_CS[IGN 1988 SM height,VERT_DATUM[IGN 1988 SM,2005],UNIT[m,1.0]]";
    }
}
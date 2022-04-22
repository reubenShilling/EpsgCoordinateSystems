using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kuwait_PWD : IEpsgCoordinateSystem
    {private const int _srid = 5788; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kuwait PWD";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Kuwait PWD,VERT_DATUM[Kuwait PWD,2005,AUTHORITY[EPSG,5186]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5788]]";

        public string EsriWkt => "VERT_CS[Kuwait PWD,VERT_DATUM[Kuwait PWD,2005],UNIT[m,1.0]]";
    }
}
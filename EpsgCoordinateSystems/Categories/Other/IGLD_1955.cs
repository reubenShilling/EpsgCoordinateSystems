using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGLD_1955 : IEpsgCoordinateSystem
    {private const int _srid = 5608; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGLD 1955";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGLD 1955,VERT_DATUM[International Great Lakes Datum 1955,2005,AUTHORITY[EPSG,5204]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5608]]";

        public string EsriWkt => "VERT_CS[IGLD 1955,VERT_DATUM[International Great Lakes Datum 1955,2005],UNIT[m,1.0]]";
    }
}
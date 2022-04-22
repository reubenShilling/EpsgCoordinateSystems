using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hon_Dau_1992 : IEpsgCoordinateSystem
    {private const int _srid = 5727; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hon Dau 1992";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Hon Dau 1992,VERT_DATUM[Hon Dau 1992,2005,AUTHORITY[EPSG,5126]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5727]]";

        public string EsriWkt => "VERT_CS[Hon Dau 1992,VERT_DATUM[Hon Dau 1992,2005],UNIT[m,1.0]]";
    }
}
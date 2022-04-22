using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Baltic_1982 : IEpsgCoordinateSystem
    {private const int _srid = 5786; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Baltic 1982";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Baltic 1982,VERT_DATUM[Baltic 1982,2005,AUTHORITY[EPSG,5184]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5786]]";

        public string EsriWkt => "VERT_CS[Baltic 1982,VERT_DATUM[Baltic 1982,2005],UNIT[m,1.0]]";
    }
}
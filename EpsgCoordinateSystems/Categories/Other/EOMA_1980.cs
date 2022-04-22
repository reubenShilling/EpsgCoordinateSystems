using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class EOMA_1980 : IEpsgCoordinateSystem
    {private const int _srid = 5787; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "EOMA 1980";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[EOMA 1980,VERT_DATUM[Baltic 1980,2005,AUTHORITY[EPSG,5185]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5787]]";

        public string EsriWkt => "VERT_CS[EOMA 1980,VERT_DATUM[Baltic 1980,2005],UNIT[m,1.0]]";
    }
}
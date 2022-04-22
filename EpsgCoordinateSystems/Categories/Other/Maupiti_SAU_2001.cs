using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Maupiti_SAU_2001 : IEpsgCoordinateSystem
    {private const int _srid = 5604; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maupiti SAU 2001";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Maupiti SAU 2001,VERT_DATUM[Maupiti SAU 2001,2005,AUTHORITY[EPSG,5199]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5604]]";

        public string EsriWkt => "VERT_CS[Maupiti SAU 2001,VERT_DATUM[Maupiti SAU 2001,2005],UNIT[m,1.0]]";
    }
}
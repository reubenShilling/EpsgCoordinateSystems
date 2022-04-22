using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Constanta : IEpsgCoordinateSystem
    {private const int _srid = 5781; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Constanta";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Constanta,VERT_DATUM[Constanta,2005,AUTHORITY[EPSG,5179]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5781]]";

        public string EsriWkt => "VERT_CS[Constanta,VERT_DATUM[Constanta,2005],UNIT[m,1.0]]";
    }
}
using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dansk_Normal_Nul : IEpsgCoordinateSystem
    {private const int _srid = 5733; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Dansk Normal Nul";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Dansk Normal Nul,VERT_DATUM[Dansk Normal Nul,2005,AUTHORITY[EPSG,5132]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5733]]";

        public string EsriWkt => "VERT_CS[Dansk Normal Nul,VERT_DATUM[Dansk Normal Nul,2005],UNIT[m,1.0]]";
    }
}
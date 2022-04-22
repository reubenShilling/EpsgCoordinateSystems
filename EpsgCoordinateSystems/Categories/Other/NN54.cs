using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NN54 : IEpsgCoordinateSystem
    {private const int _srid = 5776; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NN54";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[NN54,VERT_DATUM[Norway Normal Nul 1954,2005,AUTHORITY[EPSG,5174]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5776]]";

        public string EsriWkt => "VERT_CS[NN54,VERT_DATUM[Norway Normal Nul 1954,2005],UNIT[m,1.0]]";
    }
}
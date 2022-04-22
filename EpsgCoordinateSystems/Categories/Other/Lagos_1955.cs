using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lagos_1955 : IEpsgCoordinateSystem
    {private const int _srid = 5796; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Lagos 1955";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Lagos 1955,VERT_DATUM[Lagos 1955,2005,AUTHORITY[EPSG,5194]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5796]]";

        public string EsriWkt => "VERT_CS[Lagos 1955,VERT_DATUM[Lagos 1955,2005],UNIT[m,1.0]]";
    }
}